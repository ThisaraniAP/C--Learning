using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicals
{
    public partial class Calculator : Form
    {

        string currentInput = string.Empty;
        string firstNumber = string.Empty;
        string secondNumber = string.Empty;
        char currentOperator = ' ';
        bool isOperatorClicked = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                currentInput = string.Empty;
                isOperatorClicked = false;
            }

            Button button = (Button)sender;
            currentInput += button.Text;
            txtCal.Text = currentInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                currentInput = string.Empty;
                isOperatorClicked = false;
            }

            Button button = (Button)sender;
            currentInput += button.Text;
            txtCal.Text = currentInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                currentInput = string.Empty;
                isOperatorClicked = false;
            }

            Button button = (Button)sender;
            currentInput += button.Text;
            txtCal.Text = currentInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                currentInput = string.Empty;
                isOperatorClicked = false;
            }

            Button button = (Button)sender;
            currentInput += button.Text;
            txtCal.Text = currentInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                currentInput = string.Empty;
                isOperatorClicked = false;
            }

            Button button = (Button)sender;
            currentInput += button.Text;
            txtCal.Text = currentInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                currentInput = string.Empty;
                isOperatorClicked = false;
            }

            Button button = (Button)sender;
            currentInput += button.Text;
            txtCal.Text = currentInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                currentInput = string.Empty;
                isOperatorClicked = false;
            }

            Button button = (Button)sender;
            currentInput += button.Text;
            txtCal.Text = currentInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                currentInput = string.Empty;
                isOperatorClicked = false;
            }

            Button button = (Button)sender;
            currentInput += button.Text;
            txtCal.Text = currentInput;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                currentInput = string.Empty;
                isOperatorClicked = false;
            }

            Button button = (Button)sender;
            currentInput += button.Text;
            txtCal.Text = currentInput;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                currentInput = string.Empty;
                isOperatorClicked = false;
            }

            Button button = (Button)sender;
            currentInput += button.Text;
            txtCal.Text = currentInput;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && !isOperatorClicked)
            {
                firstNumber = currentInput;
                currentOperator = ((Button)sender).Text[0];
                isOperatorClicked = true;
                currentInput = string.Empty;
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && !isOperatorClicked)
            {
                firstNumber = currentInput;
                currentOperator = ((Button)sender).Text[0];
                isOperatorClicked = true;
                currentInput = string.Empty;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && !isOperatorClicked)
            {
                firstNumber = currentInput;
                currentOperator = ((Button)sender).Text[0];
                isOperatorClicked = true;
                currentInput = string.Empty;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && !isOperatorClicked)
            {
                firstNumber = currentInput;
                currentOperator = ((Button)sender).Text[0];
                isOperatorClicked = true;
                currentInput = string.Empty;
            }
        }

        private void brnEqual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(firstNumber) && !string.IsNullOrEmpty(currentInput))
            {
                secondNumber = currentInput;
                double result = PerformCalculation();
                txtCal.Text = result.ToString();
                firstNumber = result.ToString();
                currentInput = string.Empty;
                isOperatorClicked = true;
            }
        }

        private double PerformCalculation()
        {
            double num1 = double.Parse(firstNumber);
            double num2 = double.Parse(secondNumber);

            switch (currentOperator)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        return double.NaN; 
                default:
                    return double.NaN; 
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            currentInput = string.Empty;
            firstNumber = string.Empty;
            secondNumber = string.Empty;
            currentOperator = ' ';
            isOperatorClicked = false;
            txtCal.Text = string.Empty;
        }
    }
}
