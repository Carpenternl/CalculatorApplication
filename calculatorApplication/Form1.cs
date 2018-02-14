using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using newConsoleApp;
namespace calculatorApplication
{
    public partial class Form1 : Form
    {
        Tokenizer _tokenizer;
        List<ConstantToken> listofresults;
        public Form1()
        {
            InitializeComponent();
            _tokenizer = new Tokenizer();
            listofresults = new List<ConstantToken>();
        }
        //all numeric clicks (0-9) are handled through this eventhandler
        string value = "";
        bool hascomma = false;
        bool iscurrency = false;
        bool isnegative = false;
        bool valueEntered = false;
        private void Numeric_Click(object sender, EventArgs e)
        {
            // we know the user has clicked a number, we will use this value later.
            valueEntered = true;
            Button clickedButton = (Button)sender;
            value += clickedButton.Text;
            updateDisplay();
        }
        
        private void Buttonncomma_Click(object sender, EventArgs e)
        {
            //if no value has been added yet, make the value 0,
            if(!valueEntered)
            {
                value = "0,";
            }
            else
            {
                //add a comma to the value
                value += ",";
            }
            updateDisplay();
        }
        
        private void buttonnCurrency_Click(object sender, EventArgs e)
        {
            // makes sure that a user must input the '€' before adding numbers, because of formatting.
            if (!valueEntered)
            {
                iscurrency = true;
            }
            updateDisplay();
        }
        //Adding standard operators
        private void Operator_Click(object sender, EventArgs e)
        {
            Button ButtonClicked = (Button)sender;
            switch (ButtonClicked.Text)
            {
                case "+":
                    _tokenizer.AddToken(new AdditionToken());
                    break;
                case "*":
                    _tokenizer.AddToken(new MultiplicationToken());
                    break;
                case "/":
                    _tokenizer.AddToken(new DivisionToken());
                    break;
                case "%":
                    _tokenizer.AddToken(new ModuloToken());
                    break;
                case "-":
                    _tokenizer.AddToken(new SubtractionToken());
                    break;
            }
            //check wether the last item is (now) an operator
            if(_tokenizer.TokenList != null && _tokenizer.TokenList[_tokenizer.TokenList.Count-1] is OperatorToken)
            {
                clearvalue();
            }
            updateDisplay();
        }
        string updatedtext;
        public void updateDisplay()
        {
            updatedtext = _tokenizer.ToString();
            // a valid value has been entered

            if (valueEntered)
            {
                _tokenizer.AddToken(new ConstantToken(double.Parse(value), iscurrency, isnegative));
                //simply print the tokenarray:
                updatedtext = _tokenizer.ToString();
                
            }
            else
            {
                if (isnegative)
                {
                    updatedtext += "-";
                }
                if (iscurrency)
                {
                    updatedtext += "€";
                }
                updatedtext += value;
            }
            if (value.Contains(',') && !double.Parse(value).ToString().Contains(","))
            {
                updatedtext += ',';
            }
                userinput.Text = updatedtext;
        }

        private void buttonomin_Click(object sender, EventArgs e)
        {
            //if the last item is an operator, use the minus as a modifier for the value
            if (_tokenizer.TokenList != null && _tokenizer.TokenList[_tokenizer.TokenList.Count-1] is OperatorToken)
            {
                //make sure the minus is only used before a value has been entered
                if(!valueEntered)
                {
                    isnegative = true;
                }
            }
            else
            {
                //otherwise use the minus as another token
                this.Operator_Click(sender, e);
            }
            updateDisplay();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            if(_tokenizer.TokenList != null)
            {
                bool isvalid = _tokenizer.validate();
                // divide by zero error found
                if (!isvalid)
                {
                    convertedinput.Text = "Sorry, you cannot divide by Zero";

                }
                else
                {
                    if (listofresults.Count > 0)
                    {
                        _tokenizer.constructTree(listofresults[0]);
                        clearvalue();
                    }
                    else
                    {
                        _tokenizer.constructTree();
                    }
                    convertedinput.Text = _tokenizer.ToString();
                    userinput.Clear();
                    _tokenizer.buildTree();
                    ConstantToken resulttoken = _tokenizer.TokenList[0].GetResult();
                    listofresults.Insert(0, resulttoken);
                    resultlistview.Items.Clear();
                    foreach (var a in listofresults)
                    {
                        resultlistview.Items.Add(a.Print());
                    }
                }
            }
            
            Operator_Click(sender,e);
            _tokenizer.TokenList = null;
            updateDisplay();
        }
        private void clearvalue()
        {
            value = "";
            valueEntered = false;
            iscurrency = false;
            isnegative = false;
            hascomma = false;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            userinput.Clear();
            clearvalue();
            _tokenizer.TokenList = null;
            Console.WriteLine(_tokenizer.ToString());
            updateDisplay();
        }
    }
}
