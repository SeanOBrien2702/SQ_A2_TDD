using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnArea_Click(object sender, EventArgs e)
        {
            lbArea.Text = Tri.getArea(Int32.Parse(txtSideB.Text), Int32.Parse(txtSideA.Text)).ToString();
        }

        private void btnHypo_Click(object sender, EventArgs e)
        {
            lbSideC.Text = Tri.getHypotenuse(Int32.Parse(txtSideA.Text), Int32.Parse(txtSideB.Text)).ToString();
        }


        private void btnAngle_Click(object sender, EventArgs e)
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
                lbError.Text = "Invalid angles";
            }
        }
    }
    
}
