using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_Edabit_practice
{
    public class test13
    {
        public static bool ProfitableGamble(double prob, int prize, double pay)
        {
            if (prob * prize > pay)
            {
                return true;
            }
            return false;
        }
    }
}
