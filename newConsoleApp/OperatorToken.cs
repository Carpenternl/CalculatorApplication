using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newConsoleApp
{
    public abstract class OperatorToken : MathToken
    {
        public MathToken left;
        public MathToken right;
        public void build(MathToken left, MathToken right = null)
        {
            this.left = left;
            this.right = right;
        }
    }
    //Operator classes
    public class AdditionToken : OperatorToken
    {
        public override ConstantToken GetResult()
        {
            return left.GetResult() + right.GetResult();
        }

        public override string Print()
        {
            return "+";
        }
    }
    public class SubtractionToken : OperatorToken
    {
        public override ConstantToken GetResult()
        {
            return left.GetResult() - right.GetResult();
        }

        public override string Print()
        {
            return "-";
        }
    }
    public class MultiplicationToken: OperatorToken
    {
        public override ConstantToken GetResult()
        {
            return left.GetResult() * right.GetResult();
        }

        public override string Print()
        {
            return "*";
        }
    }
    public class DivisionToken : OperatorToken
    {
        public override ConstantToken GetResult()
        {
            return left.GetResult() / right.GetResult();
        }

        public override string Print()
        {
            return "/";
        }
    }
    public class ModuloToken : OperatorToken
    {
        public override ConstantToken GetResult()
        {
            return left.GetResult() % right.GetResult();
        }

        public override string Print()
        {
            return "%";
        }
    }
}
