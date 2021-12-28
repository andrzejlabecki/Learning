namespace Calculator
{
    public partial class Panel : Form
    {
        bool isDot = false;
        bool isNegative = false;

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
    }
}