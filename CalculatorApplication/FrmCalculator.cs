using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{   
    public partial class FrmCalculator : Form
    {

        private CalculatorClass cal;
        private double num1;
        private double num2; 
        
        public FrmCalculator()
        {
            InitializeComponent();
            
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");

            cal = new CalculatorClass();
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            cal = new CalculatorClass();        
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            if (cbOperator.SelectedIndex == 1)
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }

            else if (cbOperator.SelectedIndex == 2)
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }

            else if (cbOperator.SelectedIndex == 3)
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }

            else if (cbOperator.SelectedIndex == 4)
            {
                cal.CalculateEvent += new Formula<double>(cal.GetQuitient);
                lblDisplayTotal.Text = cal.GetQuitient(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQuitient);
            }
        }
    }
}
