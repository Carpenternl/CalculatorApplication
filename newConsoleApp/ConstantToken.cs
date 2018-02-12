using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newConsoleApp
{
    public class ConstantToken : MathToken
    {
        public double rawValue;
        bool isCurrency;
        bool isnegative;
        

        public ConstantToken(double value, bool isCurrency, bool isnegative)
        {
            this.rawValue = value;
            this.isCurrency = isCurrency;
            this.isnegative = isnegative;
        }


        public override ConstantToken GetResult()
        {

            return new ConstantToken(rawValue, isCurrency, isnegative);
        }
        //Operators
        public static ConstantToken operator +(ConstantToken left, ConstantToken right)
        {
            // new value
            double newvalue = left.rawValue + right.rawValue;
            //always convert to currency if left or right is a currency
            bool newCurrency = false;
            if (left.isCurrency | right.isCurrency)
            {
                newCurrency = true;
            }
            bool newNegative = false;
            if (newvalue < 0)
            {
                newNegative = true;
            }
            return new ConstantToken(newvalue, newCurrency, newNegative);
        }
        public static ConstantToken operator -(ConstantToken left, ConstantToken right)
        {
            // new value
            double newvalue = left.rawValue - right.rawValue;
            //always convert to currency if left or right is a currency
            bool newCurrency = false;
            if (left.isCurrency | right.isCurrency)
            {
                newCurrency = true;
            }
            bool newNegative = false;
            if (newvalue < 0)
            {
                newNegative = true;
            }
            return new ConstantToken(newvalue, newCurrency, newNegative);
        }
        public static ConstantToken operator /(ConstantToken left, ConstantToken right)
        {
            // new value
            double newvalue = left.rawValue / right.rawValue;
            //always convert to currency if left or right is a currency
            bool newCurrency = false;
            if (left.isCurrency | right.isCurrency)
            {
                newCurrency = true;
            }
            bool newNegative = false;
            if (newvalue < 0)
            {
                newNegative = true;
            }
            return new ConstantToken(newvalue, newCurrency, newNegative);
        }
        public static ConstantToken operator *(ConstantToken left, ConstantToken right)
        {
            // new value
            double newvalue = left.rawValue * right.rawValue;
            //always convert to currency if left or right is a currency
            bool newCurrency = false;
            if (left.isCurrency | right.isCurrency)
            {
                newCurrency = true;
            }
            bool newNegative = false;
            if (newvalue < 0)
            {
                newNegative = true;
            }
            return new ConstantToken(newvalue, newCurrency, newNegative);
        }
        public static ConstantToken operator %(ConstantToken left, ConstantToken right)
        {
            // new value
            double newvalue = left.rawValue % right.rawValue;
            //always convert to currency if left or right is a currency
            bool newCurrency = false;
            if (left.isCurrency | right.isCurrency)
            {
                newCurrency = true;
            }
            bool newNegative = false;
            if (newvalue < 0)
            {
                newNegative = true;
            }
            return new ConstantToken(newvalue, newCurrency, newNegative);
        }

        public override string Print()
        {
            double newvalue = rawValue;
            string result = "";
            if (isnegative)
            {
                newvalue = newvalue * -1;
                result = "-";
            }
            if (isCurrency)
            {
                result += "€";
            }
            result += newvalue.ToString();
            return result;
        }

    }
}
