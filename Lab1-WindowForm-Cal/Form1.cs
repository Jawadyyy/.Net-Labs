namespace Project1
{
    public partial class Calculator : Form
    {
        double n1 = 0;
        double n2 = 0;
        String op = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(display.Text);
            display.Clear();

            if (op == "+")
            {
                display.Text = (n1 + n2).ToString();
            }
            else if (op == "-")
            {
                display.Text = (n1 - n2).ToString();
            }
            else if (op == "x")
            {
                display.Text = (n1 * n2).ToString();
            }
            else if (op == "/")
            {
                display.Text = (n1 / n2).ToString();
            }
            else if (op == "%")
            {
                display.Text = (n1 % n2).ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            display.Clear();
            op = "+";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (display.Text == ".")
            {
                display.Text = ".";
            }
            else
            {
                display.Text += ".";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "0";
            else
                display.Text += "0";
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click_1(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "1";
            else
                display.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "2";
            else
                display.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "3";
            else
                display.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "4";
            else
                display.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "5";
            else
                display.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "6";
            else
                display.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "7";
            else
                display.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "8";
            else
                display.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Text = "9";
            else
                display.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            display.Clear();
            op = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            display.Clear();
            op = "x";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            display.Clear();
            op = "/";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(display.Text);
            display.Clear();
            op = "%";
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
