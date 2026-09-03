namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // Comment example! I finished this project on tuesday after class, but it was almost completely done before that point.
        public Form1()
        {
            InitializeComponent();
        }

        decimal operand1 = 0.0m;
        string operator1;
        decimal operand2 = 0.0m;

        decimal result = 0.0m;


        /*
         * label4Click: Exists due to accidentally clicking on label4 twice when editing.
         */
        private void label4_Click(object sender, EventArgs e)
        {

        }

        // textBox1_TextChanged, as well as the other 2 call clearResult, clearing textbox4
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


        /*button1_Click. Will turn the textbox text into decimal values with tryParse.
         * Then calls calculate, sending those two decimals, rounds the result, then
         * displays that result in textBox4.
         */
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

            result = Calculate(operand1, operand2);

            result = Math.Round(result, 4);

            textBox4.Text = Convert.ToString(result);

            textBox1.Focus();
        }

        /*Calculate:
         * Takes the decimal operand1 and decimal operand2.
         * Calculates the values for the program. Called by button1_Click.
         */
        private decimal Calculate(decimal operand1, decimal operand2)
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

        // clearResult clears textBox4. 
        private void clearResult()
        {
            textBox4.Clear();
        }

        // button2_Click is the exit button. It does as it says.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
