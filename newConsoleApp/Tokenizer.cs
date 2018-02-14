using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newConsoleApp
{
    public class Tokenizer
    {
        public List<MathToken> TokenList;

        public Tokenizer()
        {

        }

        // Add a new token to the list
        public void AddToken(MathToken tokenToAdd)
        {
            if (TokenList == null)
            {
                TokenList = new List<MathToken>();
                TokenList.Add(tokenToAdd);
            }
            else
            {

                //check if the token is the same type as last token
                var a = tokenToAdd is OperatorToken;
                var b = TokenList[TokenList.Count-1] is OperatorToken;
                //the tokens are different
                if(a !=b)
                {
                    //add new token
                    TokenList.Add(tokenToAdd);
                }
                else
                {
                    //replace last token
                    TokenList[TokenList.Count - 1] = tokenToAdd;
                }
            }
        }
        //returns a string result of all tokens
        public override string ToString()
        {
            string result = "";
            if(TokenList != null)
            {
                foreach(var a in TokenList)
                {
                    result += a.Print();
                }
            }
            return result;
        }
        public bool validate()
        {
            if(TokenList == null)
            {
                return false;
            }
            for (int i = 0; i < TokenList.Count-1; i++)
            {
                MathToken currenttoken = TokenList[i];
                if(currenttoken is OperatorToken)
                {
                    if ((currenttoken is DivisionToken | currenttoken is ModuloToken) & TokenList[i + 1].GetResult().rawValue == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void constructTree(ConstantToken firsttoken = null)
        {
            //first remove starting and ending constructors;
            int a = 0;
            while (a < TokenList.Count)
            {
                if (TokenList[a] is OperatorToken)
                {
                    //there is a token ready to insert, only run this for first token
                    if (firsttoken != null && a == 0)
                    {
                        TokenList.Insert(a, firsttoken);
                    }
                    else
                    {
                        //remove the first operator, as it will not have a left value to work with.
                        TokenList.RemoveAt(a);
                    }
                }
                // now do the same for the last item in the array
                // using this equation makes sure the while is only looped through twice;
                a = a + TokenList.Count - 1;
            }

            

        }
        public void buildTree()
        {
            //now the tree is ready to be built:
            int a = 1;
            while (a < TokenList.Count - 1)
            {
                Console.WriteLine($"test {a} result {this.ToString()}");
                OperatorToken newToken;
                switch (TokenList[a].Print())
                {
                    case "*":
                        //create new token
                        newToken = new MultiplicationToken();
                        //take left and right values (could be constants or ready built tokens:
                        //                                 a
                        // before: ... | 5 | [ + ] | 2 | [ * ] | 3 |
                        newToken.build(TokenList[a - 1], TokenList[a + 1]);
                        // before: ... | 5 | [ + ] | 2 | [ * ] | 3 |
                        a = a - 1;
                        //                           a
                        // before: ... | 5 | [ + ] | 2 | [ * ] | 3 |
                        TokenList[a] = newToken;
                        // after: ... | 5 | [ + ] | [2*3] | [ * ] | 3 |
                        TokenList.RemoveRange(a + 1, 2);
                        //        ... | 5 | [ + ] | [2*3] |
                        break;
                    case "/":
                        //create new token
                        newToken = new DivisionToken();
                        newToken.build(TokenList[a - 1], TokenList[a + 1]);
                        a = a - 1;
                        TokenList[a] = newToken;
                        TokenList.RemoveRange(a + 1, 2);
                        break;
                    case "%":
                        newToken = new ModuloToken();
                        newToken.build(TokenList[a - 1], TokenList[a + 1]);
                        a = a - 1;
                        TokenList[a] = newToken;
                        TokenList.RemoveRange(a + 1, 2);
                        break;
                    case "+":
                        break;
                    case "-":
                        break;
                }
                a++;
            }
            a = 1;
            while (a < TokenList.Count - 1)
            {
                Console.WriteLine($"test {a} result {this.ToString()}");
                OperatorToken newToken;
                switch (TokenList[a].Print())
                {
                    case "+":
                        //create new token
                        newToken = new AdditionToken();
                        //take left and right values (could be constants or ready built tokens:
                        //                                 a
                        // before: ... | 5 | [ + ] | 2 | [ * ] | 3 |
                        newToken.build(TokenList[a - 1], TokenList[a + 1]);
                        // before: ... | 5 | [ + ] | 2 | [ * ] | 3 |
                        a = a - 1;
                        //                           a
                        // before: ... | 5 | [ + ] | 2 | [ * ] | 3 |
                        TokenList[a] = newToken;
                        // after: ... | 5 | [ + ] | [2*3] | [ * ] | 3 |
                        TokenList.RemoveRange(a + 1, 2);
                        //        ... | 5 | [ + ] | [2*3] |
                        break;
                    case "-":
                        //create new token
                        newToken = new SubtractionToken();
                        newToken.build(TokenList[a - 1], TokenList[a + 1]);
                        a = a - 1;
                        TokenList[a] = newToken;
                        TokenList.RemoveRange(a + 1, 2);
                        break;
                }
                a++;
            }
        }
    }
}
