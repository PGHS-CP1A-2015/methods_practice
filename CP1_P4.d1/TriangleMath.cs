using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1_P4_d1
{
    class TriangleMath
    {
        public static double calculateSideC(double sidea, double sideb, double angleC)
        {
            double angleCInRads = angleC * Math.PI / 180;
            return Math.Sqrt(
                Math.Pow(sidea, 2) +
                Math.Pow(sideb, 2) -
                (2 * sidea * sideb * Math.Cos(angleCInRads))
                );
        }
    }

}
