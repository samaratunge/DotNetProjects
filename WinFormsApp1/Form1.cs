namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Calculator calculator = null;
        double number1;
        double number2;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operation = "+";
            number1 = Double.Parse(this.no1.Text);
            number2 = Double.Parse(this.no2.Text);
            this.result.Text = calculator.calculate(operation, number1, number2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string operation = "-";
            number1 = Double.Parse(this.no1.Text);
            number2 = Double.Parse(this.no2.Text);
            this.result.Text = calculator.calculate(operation, number1, number2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string operation = "*";
            number1 = Double.Parse(this.no1.Text);
            number2 = Double.Parse(this.no2.Text);
            this.result.Text = calculator.calculate(operation, number1, number2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string operation = "/";
            number1 = Double.Parse(this.no1.Text);
            number2 = Double.Parse(this.no2.Text);
            this.result.Text = calculator.calculate(operation, number1, number2).ToString();
        }
    }
}
