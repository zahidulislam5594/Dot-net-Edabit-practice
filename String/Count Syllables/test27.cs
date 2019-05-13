using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_Edabit_practice
{
    public class test27
    {
        public static int NumberSyllables(string word)
        {
            string[] word1 = word.Split('-');
            return word1.Length;
        }
    }
}
