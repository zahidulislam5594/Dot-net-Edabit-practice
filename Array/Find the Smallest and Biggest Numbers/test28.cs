using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_Edabit_practice
{
    public class test28
    {
        public static double[] FindMinMax(double[] values)
        {
            Console.WriteLine(values.Min());
            Console.WriteLine(values.Max());
            return new double[] { values.Min(), values.Max()};
        }
    }
}
