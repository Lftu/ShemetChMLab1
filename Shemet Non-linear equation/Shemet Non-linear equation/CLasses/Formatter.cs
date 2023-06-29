using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shemet_Non_linear_equation.CLasses
{
    public static class Formatter
    {
        public static string GetHeader()
        {
            string header = "Iteration             Xn                                   |Xn - Xn-1|                                 f(x)";
            return header;
        }
        public static string GetStartInfo(double Xn, double f)
        {
            string info = 0 + "               " + Xn + "                                                                          " + f;
            return info;
        }
        public static string GetInfo(int iterations, double Xn, double Xpr, double f)
        {
            string iterationInfo = iterations + "               " + Xn + "      " + Math.Abs(Xn - Xpr) + "      " + f;
            return iterationInfo;
        }
    }
}
