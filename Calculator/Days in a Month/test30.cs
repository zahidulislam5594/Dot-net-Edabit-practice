using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_Edabit_practice
{
    public class test30
    {
        public static int Days(int month, int year)
        {
            return System.DateTime.DaysInMonth(year, month);

        }
    }
}
