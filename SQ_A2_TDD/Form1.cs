/*
*  FILE          : Form1.cs
*  PROJECT       : SQ Assignment 2 TDD
*  PROGRAMMER    : Sean O'Brien
*  FIRST VERSION : 2018-11-22
*  DESCRIPTION   : This file contains all of the event handlers for when a button
*                  is pressed.
*/
using System;
using System.Windows.Forms;


namespace SQ_A2_TDD
{
    public partial class Form1 : Form
    {

        Triangle Tri = new Triangle();

        public Form1()
        {
            InitializeComponent();
            
        }

        /*
        * NAME: btnHypo_Click
        * DESCRIPTION: Calculate the hypotenuse of a right angle triangle
        * Perameters: object sender, EventArgs e
        * Returns: void
        */
        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                lbArea.Text = Tri.getArea(Int32.Parse(txtSideB.Text), Int32.Parse(txtSideA.Text)).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in sides A and B before calculating area");
            }
        }

        /*
        * NAME: btnHypo_Click
        * DESCRIPTION: Calculate the hypotenuse of a right angle triangle
        * Perameters: object sender, EventArgs e
        * Returns: void
        */
        private void btnHypo_Click(object sender, EventArgs e)
        {
            try
            {
                lbSideC.Text = Tri.getHypotenuse(Int32.Parse(txtSideA.Text), Int32.Parse(txtSideB.Text)).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in sides A and B before calculating the hypotenuse");
            }

        }

        /*
        * NAME: btnAngle_Click
        * DESCRIPTION: Calculate the total angles of all 3 angles
        * Perameters: object sender, EventArgs e
        * Returns: void
        */
        private void btnAngle_Click(object sender, EventArgs e)
        {
            try
            {
                Tri.AngleA = Int32.Parse(txtAngleA.Text);
                Tri.AngleB = Int32.Parse(txtAngleB.Text);
                Tri.AngleC = Tri.getAngle(Tri.AngleA, Tri.AngleB);
                if (Tri.validateAngles(Tri.AngleA, Tri.AngleB, Tri.AngleC))
                {
                    lbAngleC.Text = Tri.AngleC.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid angles: sum of angles must equal 180");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill whole number for angles A and B before calculating angle C");
            }            
        }
    }
    
}
