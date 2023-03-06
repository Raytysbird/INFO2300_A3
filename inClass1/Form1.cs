using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClass1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            // clears the display
            if (isOperationPerformed)
            {
                txtDisplay.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;

            // stops multiple "."
            if (button.Text == ".")
            {
                if(!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + button.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + button.Text;

            


        }
        //operation buttons
        private void OptClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(txtDisplay.Text);
            lblEquation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }
        // CE and C buttons
        private void btnClearEvery_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // equations
            switch (operationPerformed)
            {
                case "+":
                    txtDisplay.Text = (resultValue + double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultValue - double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultValue * double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (resultValue / double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
        }
    }
}
