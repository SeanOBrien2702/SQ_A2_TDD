/*
*  FILE          : Triangle.cs
*  PROJECT       : SQ Assignment 2 TDD
*  PROGRAMMER    : Sean O'Brien
*  FIRST VERSION : 2018-11-22
*  DESCRIPTION   : The purpose of this assignemtn is to use TDD to create a simple
*                  program that will calculate different measurements of the a triangle.
*                  With TDD, the unit tests were created first then functioning code was
*                  created after. This code is tested by the tests made before hand to 
*                  determine if they are not working. If not, the code is edited until it dose.
*/
using System;

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
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                sideA = value;
            }
        }
        public int SideB
        {
            get { return sideB; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                sideB = value;
            }
        }
        public int SideC
        {
            get { return sideC; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                sideC = value;
            }
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


        /*
        * NAME: validateLenth
        * DESCRIPTION: Cheklc to see if the lenth of a side is greater then 0
        * Perameters: int side
        * Returns: bol valid
        */
        public bool validateLenth(int side)
        {
            bool valid = false;
            if(side > 0)
            {
                valid = true;
            }
            return valid;
        }


        /*
        * NAME: validateAngles
        * DESCRIPTION: Check to see if the total angles of all 3 angles equales 180 degrees
        * Perameters: object sender, EventArgs e
        * Returns: bool valid
        */
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


        /*
        * NAME: getHpyotenuse
        * DESCRIPTION: Calculate the hyptotenuse of aright angle trinagle
        * Perameters: object sender, EventArgs e
        * Returns: return answer
        */
        public double getHypotenuse(int Side1, int Side2)
        {
            double answer = Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2));
            answer = Math.Round(answer, 3, MidpointRounding.AwayFromZero);
            return answer;
        }


        /*
        * NAME: getArea
        * DESCRIPTION: Calculate the total area of the triangle
        * Perameters: int Side1, int Side2
        * Returns: return answer
        */
        public double getArea(int Side1, int Side2)
        {
            double answer = (Side1 * Side2 * 0.5);
            answer = Math.Round(answer, 3, MidpointRounding.AwayFromZero);
            return answer;
        }


        /*
        * NAME: getClick
        * DESCRIPTION: Calculate the total angles of all 3 angles
        * Perameters: int angle1, int angle2
        * Returns: return answer
        */
        public int getAngle(int angle1, int angle2)
        {
            int answer = 180 - (angle1 + angle2);
         
            return answer;
        }
    }
}
