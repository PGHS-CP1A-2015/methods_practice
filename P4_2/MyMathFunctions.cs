using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2
{
    public static class MyMathFunctions
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
