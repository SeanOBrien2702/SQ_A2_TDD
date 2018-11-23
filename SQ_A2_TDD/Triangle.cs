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

        public double getHypotenuse(int SideA, int SideB)
        {
            double answer = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
            answer = Math.Round(answer, 3, MidpointRounding.AwayFromZero);
            return answer;
        }
        public double getArea(int SideA, int SideB)
        {
            double answer = (SideA * SideB * 0.5);
            answer = Math.Round(answer, 3, MidpointRounding.AwayFromZero);
            return answer;
        }

        public int getAngle(int angleA, int angleB)
        {
            int answer = 180 - (angleA + angleB);
            if (!validateAngles(answer, angleA, angleB))
            {
                answer = 0;
            }
            return answer;
        }



    }
}
