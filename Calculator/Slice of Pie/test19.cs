using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_Edabit_practice
{
    public class test19
    {
        public static bool EqualSlices(int total, int people, int each)
        {
            if (people * each <= total)
            {
                return true;
            }
            return false;
        }
    }
}
