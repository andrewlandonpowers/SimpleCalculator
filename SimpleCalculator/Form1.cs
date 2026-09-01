namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal operand1 = 0.0m;
        string operator1;
        decimal operand2 = 0.0m;

        decimal result = 0.0m;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clearResult();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            clearResult();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            clearResult();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(textBox3.Text, out decimal parsedOperand))
            {
                operand2 = parsedOperand;
            }
            else
            {
                operand2 = 0.0m;
            }

            if (decimal.TryParse(textBox1.Text, out decimal parsedOperand2))
            {
                operand1 = parsedOperand2;
            }
            else
            {
                operand1= 0.0m;
            }

            result = Calculate(operand1, operator1, operand2);

            result = Math.Round(result, 4);

            textBox4.Text = Convert.ToString(result);

            textBox1.Focus();
        }


        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            if (textBox2.Text == "/")
            {
                result = (Math.Round((operand1 / operand2), 4));
            }
            else if (textBox2.Text == "+")
            {
                result = (Math.Round((operand1 + operand2), 4));
            }
            else if (textBox2.Text == "-")
            {
                result = (Math.Round((operand1 - operand2), 4));
            }
            else if (textBox2.Text == "*")
            {
                result = (Math.Round((operand1 * operand2), 4));
            }
            else { result = 0.0m; }

            return result;
        }

        private void clearResult()
        {
            textBox4.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
