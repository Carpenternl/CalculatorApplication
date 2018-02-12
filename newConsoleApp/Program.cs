using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            tests();
            string test = "€,5";
            double result;
            bool parsed = double.TryParse(test,out result);
            if (parsed)
            {
                Console.WriteLine($"success! { result.ToString() }+{test}");
            }
            else
            {
                Console.WriteLine("fail!");
            }
            Console.Read();
        }
        public static void tests()
        {
            ConstantToken t = new ConstantToken(5, false, false);
            Console.WriteLine(t.Print());
            if (t is MathToken)
            {
                Console.WriteLine("T is a Constant");
            }
            AdditionToken add = new AdditionToken();
            Console.WriteLine(add.GetType());
            if (add is ConstantToken)
            {
                Console.WriteLine("add is a operator token");
            }
            else
            {
                Console.WriteLine("add is not an operator token");
            }
            Tokenizer tokenizer = new Tokenizer();
            MathToken token1 = new AdditionToken();
            MathToken token2 = new ConstantToken(5, false, false);
            MathToken token3 = new MultiplicationToken();
            MathToken token4 = new ConstantToken(3, false, false);
            MathToken token5 = new DivisionToken();
            MathToken token6 = new ConstantToken(2, false, false);
            MathToken token7 = new ModuloToken();
            tokenizer.AddToken(token1);
            Console.WriteLine(tokenizer.ToString());
            tokenizer.AddToken(token2);
            Console.WriteLine(tokenizer.ToString());
            tokenizer.AddToken(token3);
            Console.WriteLine(tokenizer.ToString());
            tokenizer.AddToken(token1);
            Console.WriteLine(tokenizer.ToString());
            tokenizer.AddToken(token4);
            Console.WriteLine(tokenizer.ToString());
            tokenizer.AddToken(token5);
            Console.WriteLine(tokenizer.ToString());
            tokenizer.AddToken(token6);
            Console.WriteLine(tokenizer.ToString());
            tokenizer.constructTree();
            Console.WriteLine(tokenizer.ToString());
            Console.WriteLine(tokenizer.TokenList[0].GetResult().Print());
            var c = 5 - -4;
            Console.WriteLine(c.ToString());
            Console.Read();
        }
    }
}
