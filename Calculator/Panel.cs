namespace Calculator
{
    public partial class Panel : Form
    {
        bool isDot = false;
        bool isNegative = false;
        string operation = string.Empty;

        public Panel()
        {
            InitializeComponent();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!isDot)
            {
                textBoxInput.Text += ".";
                isDot = true;
            }
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length == 0)
                textBoxInput.Text = isNegative ? "+" : "-";
            else if (textBoxInput.Text[0] != '+' && textBoxInput.Text[0] != '-')
                textBoxInput.Text = isNegative ? "+" + textBoxInput.Text : "-" + textBoxInput.Text;
            else
                textBoxInput.Text = isNegative ? String.Concat("+", textBoxInput.Text.AsSpan(1)) : String.Concat("-", textBoxInput.Text.AsSpan(1));

            isNegative = !isNegative;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "9";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            textBoxInput.Text += "+";
            isDot = false;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            textBoxInput.Text += "-";
            isDot = false;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            textBoxInput.Text += "*";
            isDot = false;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            // char [] delimeters = new char[] { '+', '-' };
            //string[] operands = textBoxInput.Text.Split(delimeters);
            string[] operands = textBoxInput.Text.Split(operation);

            int count = operands.Length;

            if (count != 2)
            {
                MessageBox.Show("You must enter 2 operands!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double operand1 = Convert.ToDouble(operands[0]);
            double operand2 = Convert.ToDouble(operands[1]);
            double? result = null;

            if (operation == "+")
                result = operand1 + operand2;
            else if (operation == "-")
                result = operand1 - operand2;
            else if (operation == "*")
                result = operand1 * operand2;
            else if (operation == "/")
                result = operand1 / operand2;

            if (result != null)
                textBoxResult.Text = result.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            isDot = false;
            isNegative = false;
            operation = string.Empty;

            textBoxInput.Text = string.Empty;
            textBoxResult.Text = string.Empty;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            textBoxInput.Text += "/";
            isDot = false;
        }
    }
}