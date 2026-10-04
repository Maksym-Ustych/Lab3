namespace Lab3_Ustych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Visible =
    textBox1.Text.Length != 0 &&
    textBox2.Text.Length != 0 &&
    textBox3.Text.Length != 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Visible =
    textBox1.Text.Length != 0 &&
    textBox2.Text.Length != 0 &&
    textBox3.Text.Length != 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button1.Visible =
    textBox1.Text.Length != 0 &&
    textBox2.Text.Length != 0 &&
    textBox3.Text.Length != 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double p = a + b + c;

            label4.Text = "Периметр: " + p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
