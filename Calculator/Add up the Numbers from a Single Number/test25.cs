using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_Edabit_practice
{
    public class test25
    {
        public static int AddUp(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
