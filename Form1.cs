namespace RQM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "Citatul autorului";
            label1.Text = "Autorul";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"Citat despre economie";
            label1.Text = $"Autorul citatului depsre economie";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"Citat despre psihologie ";
            label1.Text = $"Autorul citatului despre psihologie";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"Citat despre istorie";
            label1.Text = $"Autorul citatului despre istorie";
        }
    }
}