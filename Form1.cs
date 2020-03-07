using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        private Single sngNum1, sngNum2, sngAnswer;
        public Form1()
        {
            InitializeComponent();
        }
        private void tbxHeight_TextChanged(object sender, EventArgs e)
        {

        }


        private void tbxWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = Calculate(tbxWeight.Text, tbxHeight.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //method calc
        private string Calculate(string Num1, string Num2)
        {
            sngNum1 = Convert.ToSingle(Num1);
            sngNum2 = Convert.ToSingle(Num2);

            sngAnswer = sngNum1 / (sngNum2 * sngNum2);

            return sngAnswer.ToString();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
            

        }
    }
}
