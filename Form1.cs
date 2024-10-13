using System;
using System.Windows.Forms;

namespace Rechner
{
    public partial class Form1 : Form
    {
        private double currentResult = 0;
        private string operation = "";
        private bool isOperationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void numButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                AddNumberToTextBox(button.Text);
            }
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                SetOperation(button.Text);
            }
        }

        private void SetOperation(string op)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Bitte eine Zahl eingeben.");
                return;
            }

            if (currentResult != 0)
            {
                result_Click(null, null);
            }
            else
            {
                currentResult = Double.Parse(textBox1.Text);
            }

            operation = op;
            isOperationPressed = true;
        }

        private void result_Click(object? sender, EventArgs? e)
        {
            double inputNumber;
            if (!Double.TryParse(textBox1.Text, out inputNumber))
            {
                MessageBox.Show("Ungültige Eingabe.");
                return;
            }

            switch (operation)
            {
                case "+":
                    textBox1.Text = (currentResult + inputNumber).ToString();
                    break;
                case "-":
                    textBox1.Text = (currentResult - inputNumber).ToString();
                    break;
                case "*":
                    textBox1.Text = (currentResult * inputNumber).ToString();
                    break;
                case "/":
                    if (inputNumber != 0)
                    {
                        textBox1.Text = (currentResult / inputNumber).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Durch Null kann nicht geteilt werden.");
                    }
                    break;
            }

            currentResult = Double.Parse(textBox1.Text);
            operation = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void ResetCalculator()
        {
            textBox1.Text = "0";
            currentResult = 0;
            operation = "";
        }

        private void AddNumberToTextBox(string number)
        {
            if ((textBox1.Text == "0") || isOperationPressed)
            {
                textBox1.Text = number;
            }
            else
            {
                textBox1.Text += number;
            }
            isOperationPressed = false;
        }
    }
}
