namespace WinFormsApp_лаба_10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(this.textBox1.Text);
            double number2 = double.Parse(this.textBox2.Text);
            double number3 = double.Parse(this.textBox3.Text);
            double ma = double.MinValue;
            double[] array = { number1, number2, number3 };
            for (int i = 0; i < 3; i++)
            {
                if (array[i] >= ma)
                    ma = array[i];
            }
            MessageBox.Show("Максимум: " + ma.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(this.textBox1.Text);
            double number2 = double.Parse(this.textBox2.Text);
            double number3 = double.Parse(this.textBox3.Text);
            double mi = double.MaxValue;
            double[] array = {number1, number2, number3};
            for (int i = 0; i < 3; i++)
            {
                if (array[i] <= mi)
                    mi = array[i];
            }
            MessageBox.Show("Минимум: " + mi.ToString());
        }
    }
}
