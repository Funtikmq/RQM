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
            "Dostoevsky",
            "Gogol",
            "Tolstoy"
        };

        List<string> images = new List<string>()
        {
            "image0","image1","image2","image3","image4"
        };

       private void setQuote(int firstRandom, int secondRandom)
        {
            Random rand = new Random();
            int index = rand.Next(firstRandom, secondRandom);
            //pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(images[index]);
            textBox1.Text = citat[index];
            label1.Text = autor[index];
        }

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "Pentru generarea unui citat selecta-ți domeniul";
            label1.Text = "";
        }

       
        
        private void button1_Click(object sender, EventArgs e)
        {
            setQuote(0, 4);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setQuote(0, 4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setQuote(0, 4);
          
        }
    }
}