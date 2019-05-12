using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_Edabit_practice
{
    public class test16
    {
        public static bool HasSpaces(string str)
        {
            bool b = str.Contains(" ");
            if (b == true)
            {
                return true;
            }
            return false;
        }
    }
}
