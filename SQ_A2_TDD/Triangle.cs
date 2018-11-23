using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_A2_TDD
{
    public class Triangle
    {
       


        public bool validateLenth(int side)
        {
            bool valid = false;
            if(side > 0)
            {
                valid = true;
            }
            return valid;
        }

        public bool validateAngles(int angleA, int angleB, int angleC)
        {
            bool valid = false;
            int sum = angleA + angleB + angleC;
            if (sum == 180)
            {
                valid = true;
            }
            return valid;
        }
    }
}
