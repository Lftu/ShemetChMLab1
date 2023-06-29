using Shemet_Non_linear_equation.CLasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shemet_Non_linear_equation.Classes.Strategies
{
    internal abstract class Strategy
    {
        public void FindRoot(Func<double, double> Evaluate, int dop)
        {
            string iterationInfo;

            double nextX = Evaluate(approximateX);

            WriteStart();

            while (Math.Abs(approximateX - nextX) > precision || Math.Abs(Function.Evaluate(nextX)) > precision || iterations < dop)
            {
                iterationInfo = Formatter.GetInfo(iterations, nextX, approximateX, Function.Evaluate(nextX));
                Output.WriteToList(iterationInfo);

                approximateX = nextX;
                nextX = Evaluate(approximateX);

                iterations++;
            }

            iterationInfo = Formatter.GetInfo(iterations, nextX, approximateX, Function.Evaluate(nextX));
            Output.WriteToList(iterationInfo);

            Output.WriteToList("n = " + iterations);
        }
        public abstract void FindRoot1();
        public void WriteStart()
        {
            Output.WriteToList(Formatter.GetHeader());
            Output.WriteToList(Formatter.GetStartInfo(approximateX, Function.Evaluate(approximateX)));
        }
        public int GetIterations()
        {
            return iterations;
        }

        public void SetIterations(int iterations)
        { this.iterations = iterations; }

        public double precision = 0.00001;
        public double approximateX = -1.5;
        protected int iterations = 1;
    }
}
