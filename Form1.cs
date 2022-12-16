namespace RQM
{
    public partial class Form1 : Form
    {
     List<string> citat = new List<string>() 
     { "Primul Citat despre psihologie",
         "Al doilea citat despre psihologie",
         "Al treilea citat despre psihologie",
         "Al patrulea citat despre psihologie",
         "Al cincilea citat despre psihologie",
         "Al șaselea citat despre psihologie",
     };
            
     string[] autor = new string[6];
        //autor[0] = "Eminescu";
        //    autor[1] = "Calinescu";
        //    autor[2] = "Petrescu";
        //    autor[3] = "Caragiale";
        //    autor[4] = "Barbu";
        //    autor[5] = "Arghezi";

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "Pentru generarea unui citat selecta-ți domeniul";
            label1.Text = "";
        }

       
        
        private void button1_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            int counter = rand.Next(0,5);
            textBox1.Text = citat[counter];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"Citat despre psihologie ";
            label1.Text = $"Autorul citatului despre psihologie";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text ="";
            label1.Text ="";
        }
    }
}