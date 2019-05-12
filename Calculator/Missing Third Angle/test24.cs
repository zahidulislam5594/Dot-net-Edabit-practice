using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_Edabit_practice
{
    public class test24
    {
        public static string MissingAngle(int angle1, int angle2)
        {
            int angle = 180 - (angle1 + angle2);

            if (angle < 90) return "acute";
            else if (angle == 90) return "right";
            else if (angle > 90 && angle < 180) return "obtuse";
            else return "invalid";

        }
    }
}
