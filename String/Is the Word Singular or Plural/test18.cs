using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_Edabit_practice
{
    public class test18
    {
        public static bool IsPlural(string word)
        {
            bool b = word.EndsWith("s");
            if (b == true)
            {
                return true;
            }
            return false;
        }
    }
}
