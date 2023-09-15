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
            string selectedOperator = cbOperator.SelectedItem.ToString();

            double result = 0.0;

            switch (cbOperator)
            {
                case "+":
                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    result = cal.GetSum(num1, num2);
                    break;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            cal = new CalculatorClass();
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);


        }
    }
}
