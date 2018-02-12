using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newConsoleApp
{
    public abstract class MathToken
    {
        public abstract string Print();
        public abstract ConstantToken GetResult();

    }

}
