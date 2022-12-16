namespace RQM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "Pentru generarea unui citat selecta-ți domeniul";
            label1.Text = "";
        }

       
        
        private void button1_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            int counter = rand.Next(0,6);
            string[] citat = new string[6];
            citat[0] = "Primul Citat despre psihologie";
            citat[1] = "Al doilea citat despre psihologie";
            citat[2] = "Al treilea citat despre psihologie";
            citat[3] = "Al patrulea citat despre psihologie";
            citat[4] = "Al cincilea citat despre psihologie";
            citat[5] = "Al șaselea citat despre psihologie";
            string[] autor = new string[6];
            autor[0] = "Eminescu";
            autor[1] = "Calinescu";
            autor[2] = "Petrescu";
            autor[3] = "Caragiale";
            autor[4] = "Barbu";
            autor[5] = "Arghezi";
            
            textBox1.Text = citat[counter];
            label1.Text = autor[counter];
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