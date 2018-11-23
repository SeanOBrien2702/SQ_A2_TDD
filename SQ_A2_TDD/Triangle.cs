using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_A2_TDD
{
    public class Triangle
    {

        private int sideA;
        private int sideB;
        private int sideC;

        public int SideA
        {
            get{ return sideA; }
            set{ sideA = value; }
        }
        public int SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        public int SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        private int angleA;
        private int angleB;
        private int angleC;

        public int AngleA
        {
            get { return angleA; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                angleA = value;
            }
        }
        public int AngleB
        {
            get { return angleB; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                angleB = value;
            }
        }
        public int AngleC
        {
            get { return angleC; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                angleC = value;
            }
        }


        public bool validateLenth(int side)
        {
            bool valid = false;
            if(side > 0)
            {
                valid = true;
            }
            return valid;
        }

        public bool validateAngles(int angle1, int angle2, int angle3)
        {
            bool valid = false;
            int sum = angle1 + angle2 + angle3;
            if (sum == 180)
            {
                valid = true;
            }
            return valid;
        }

        public double getHypotenuse(int Side1, int Side2)
        {
            double answer = Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2));
            answer = Math.Round(answer, 3, MidpointRounding.AwayFromZero);
            return answer;
        }
        public double getArea(int Side1, int Side2)
        {
            double answer = (Side1 * Side2 * 0.5);
            answer = Math.Round(answer, 3, MidpointRounding.AwayFromZero);
            return answer;
        }

        public int getAngle(int angle1, int angle2)
        {
            int answer = 180 - (angle1 + angle2);
         
            return answer;
        }



    }
}
