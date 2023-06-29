using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shemet_Non_linear_equation.CLasses
{
    public static class Function
    {
        private const double t1 = 0.302;
        public static double Evaluate(double x)
        {
            double y = Math.Sqrt(x) - Math.Cos(3 * x) - 0.7;
            return y;
        }
        public static double EvaluatePohidna(double x)
        {
            double y = 1.0 / (2.0 * Math.Sqrt(x)) + 3 * Math.Sin(3 * x);
            return y;
        }
        public static double EvaluatePhi1(double x)
        {
            double phi = -0.1 * (Math.Sqrt(x) - Math.Cos(3 * x) - 0.7) + x;
            return phi;
        }
        public static double EvaluateRelaxation1(double x)
        {
            double xNext = x - t1 * Evaluate(x);
            return xNext;
        }
        public static double EvaluateNewton1(double x)
        {
            double xNext = x - Evaluate(x) / EvaluatePohidna(x);
            return xNext;
        }
    }
}
