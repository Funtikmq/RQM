namespace RQM
{
    public partial class Form1 : Form
    {
        List<string> citat = new List<string>()
     {   "Primul Citat despre psihologie",
         "Al doilea citat despre psihologie",
         "Al treilea citat despre psihologie",
         "Al patrulea citat despre psihologie",
         "Al cincilea citat despre psihologie",
         "Al șaselea citat despre psihologie",
         "Al saptelea citat despre psihologie",
         "Al optulea citat despre psihologie",
         "Al noualea citat despre psihologie",
         "Primul citat despre istorie",
         "Ultimul citat despre istorie",
         "Primul citat economie",
         "Ultimul citat despre economie"
     };

        List<string> autor = new List<string>()
        {
            "Eminescu",
            "Arghezi",
            "Blaga",
            "Petrescu",
            "Barbu",
            "Porumbescu",
            "3",
            "a",
            "s"
        };

       private void setQuote(int firstRandom, int secondRandom)
        {
            Random rand = new Random();
            int counter = rand.Next(firstRandom, secondRandom);
            textBox1.Text = citat[counter];
            label1.Text = autor[counter];
        }

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "Pentru generarea unui citat selecta-ți domeniul";
            label1.Text = "";
        }

       
        
        private void button1_Click(object sender, EventArgs e)
        {
            setQuote(0, 5);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setQuote(6, 9);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setQuote(6, 9);
          
        }
    }
}