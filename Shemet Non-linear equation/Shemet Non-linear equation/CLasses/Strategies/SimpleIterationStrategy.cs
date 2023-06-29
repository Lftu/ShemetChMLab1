using Shemet_Non_linear_equation.CLasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Shemet_Non_linear_equation.Classes.Strategies
{
    internal class SimpleIterationStrategy : Strategy
    {
        public override void FindRoot1()
        {
            FindRoot(Function.EvaluatePhi1, 7);
        }
    }
}
