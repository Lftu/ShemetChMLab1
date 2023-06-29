using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shemet_Non_linear_equation.CLasses
{
    public static class Output
    {
        public static ListBox List;

        public static void WriteToList(string text)
        {
            List.Items.Add(text);
        }
        public static void ClearList()
        {
            List.Items.Clear();
        }

    }
}
