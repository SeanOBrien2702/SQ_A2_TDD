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
        

        
        public Form1()
        {
            InitializeComponent();
            //Triangle Tri = new Triangle();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHypo_Click(object sender, EventArgs e)
        {
            Triangle Tri = new Triangle();

            double sum = Tri.getHypotenuse(Int32.Parse(txtSideA.Text), Int32.Parse(txtSideB.Text));
            lbSideC.Text = sum.ToString();
        }

    }
    
}
