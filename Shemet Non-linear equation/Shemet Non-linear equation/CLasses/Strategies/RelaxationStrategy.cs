using Shemet_Non_linear_equation.CLasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shemet_Non_linear_equation.Classes.Strategies
{
    internal class RelaxationStrategy : Strategy
    {
        public override void FindRoot1()
        {
            FindRoot(Function.EvaluateRelaxation1, 4);
        }

    }
}
