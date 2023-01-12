namespace RQM
{
    public partial class Form1 : Form
    {
        List<string> citat = new List<string>()
     {   
//Istorie
         "Istoria e o minciună pe care nimeni nu o contestă.",
         "Indiferent ce facem sau ratam să facem va influența istoria.",
         "Istoria este un vast sistem de atenționare timpurie.",
         "Cei care uită trecutul sunt condamnați să îl repete.",
         "Istoria ne avertizează că sultanul poate face oricând dintr-un pașă un eunuc.",
         "Istoria nu reprezintă decât crimele și ghinioanele umanității.",
         "Iară nu sunt vremile supt cârma omului, ci bietul om supt vremi.",
         "Preistoric, aparținând unei epoci timpurii și unui muzeu, anțedatarea artei și practica de a perpetua falsitatea. ",
         "Hegel a avut dreptate când a spus că învățam din istorie că omul nu poate învăța niciodată nimic din istorie." ,
         "Istoria e o listă de surprise. Ne poate doar pregăti să fim surprinși din nou.",
         "În istoria oricărei iubiri există un balcon ca al Julietei, pe care mai târziu se întind rufe." ,
         "Istorie, atâtea minciuni fosilizate.",
         "Istoria lumii este o curte de judecată.",
         "Patriotismul strică istoria.",
         "Oricine poate fabrica istoria, dar doar un om mare poate să o scrie.",
//Psihologie
         "Psihologia este în cele din urmă mitologie, studiul poveştilor sufletului.",
         "Psihologia te ajută să ajungi la orice concluzie doreşti. Depinde numai de cel care o mânuieşte.",
         "Scopul psihologiei este să ne dea o idee complet diferită despre lucrurile pe care le ştim cel mai bine.",
         "Factorul psihologic, atât de mult căutat, dă proceselor nevrozei obsesionale caracterul lor compulsional.",
         "Dacă singurul instrument pe care îl ai este un ciocan, ai tendința să vezi fiecare problemă ca pe un cui",
         "Cea mai mare descoperire a generației mele este că o ființă umană își poate modifica viața modificându-și atitudinile.",
         "O viața bună este un proces, nu o stare de a fi. Este o direcție, nu o destinație.",
         "Tot ceea ce ne irită în legătură cu ceilalți ne poate conduce la o înțelegere a propriei persoane",
         "Convingerile oamenilor despre abilitățile lor au un efect profund asupra acestor abilități.",
         "Cât de îndrăzneț devine omul atunci când este sigur că este iubit.",
         "Scopul psihologiei este să ne ofere o idee complet diferită despre lucrurile pe care le cunoaștem cel mai bine",
         "Nu poate exista libertate reală fără libertatea de a eșua.",
         "Principalul pericol în viață este că s-ar putea să îți iei prea multe mijloace de precauție.",
         "Omul ştie mai multe decât înţelege.",
        " De cele mai multe ori ceea ce numim noi fericire e ceea ce nu cunoaştem.",
// Economie
        " Mulți oameni au devenit pesimiști în ceea ce privește optimizarea finanțării",
        " Piața poate rămâne irațională mai lungă decât puteți rămâne solvabilă.,",
        "O bancă este un loc care vă împrumută bani dacă puteți dovedi că nu aveți nevoie de ea.,",
        "Prețul este ceea ce plătiți. Valoarea este ceea ce primești.,",
        "Fiecare scurtă teză despre economie este intrinsec falsă.",
        "Singurul buget bun este bugetul echilibrat",
        "În viața practică a vieții, nu este credința care salvează, ci neîncrederea.",
        "În afaceri nu există prieteni: există doar clienți.",
        "Nimic nu este atât de esențial în afaceri ca fiind expedient. ",
        "Este bine să dobândești, dar este mult mai bine să o păstrezi.",
        "Audacitatea în afaceri vine pe primul, pe al doilea și pe al treilea.",
        "O bancă este un loc unde vă împrumută o umbrelă când vremea este bună și vă întreabă când începe să plouă.",
        "În viață, trebuie să alegi să câștigi bani sau să-l cheltuiți. Nu este suficient timp pentru ambele.",
        "Întotdeauna cheltuiți o monedă mai mică decât câștigi",
        "Raritatea fixează prețul lucrurilor."
     };

        List<string> autor = new List<string>()
        {
            "Napoleon Bonaparte",
            "Arthur Henderson",
            "Norman Cousins",
            "George Santayana",
            "Vasile Ghica",
            "Pierre Bayle",
            "Miron Costin",
            "Ambrose Bierce",
            "George Bernard Shaw",
            "Kurt Vonnegut",
            "Vasile Ghica",
            "Valeriu Butulescu",
            "George Wihelem",
            "Goethe",
            "Oscar Wilde",
            "James Hillman",
            "Dostoievski",
            "Paul Valery",
            "Sigmund Freud",
            "Abraham Maslow",
            "William James",
            "Carl Rogers",
            "Carl Jung",
            "Albert Bandura",
            "Sigmund Freud",
            "Paul Valéry",
            "Erich Fromm",
            "Alfred Adler",
            "Alfred Adler",
            "Anatole France",
            "C.T. Jones",
            "John Maynard Keynes",
            "Bob Hope",
            "Warren Buffett",
            "Alfred Marshall",
            "Adam Smith",
            "Napoleon Bonaparte",
            "Alexandre Dumas",
            "Joseph Addison",
            "Johann Wolfgang",
            "Thomas Fuller",
            "Robert Lee Frost",
            "Edouard Bourdet",
            "Cesare Cantú",
            "Petro"
 };

        List<string> images = new List<string>()
        {
            "image0", "image1", "image2", "image3", "image4", "image5", "image6", "image7",
            "image8", "image9", "image10", "image11", "image12", "image13", "image14", "image15",
            "image16", "image17", "image18", "image19", "image20", "image21", "image22", "image23",
            "image24", "image25", "image26", "image27", "image28", "image29", "image30", "image31",
            "image32", "image33", "image34", "image35", "image36", "image37", "image38", "image39",
            "image40", "image41", "image42", "image43", "image44",
        };

        private void setQuote(int firstRandom, int secondRandom)
        {
            Random rand = new Random();
            int index = rand.Next(firstRandom, secondRandom);
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(images[index]);
            textBox1.Font = new Font("Times New Roman",14,FontStyle.Italic);
            textBox1.Text = citat[index];
            label1.Text = autor[index];
            
        }

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "Pentru generarea unui citat selectați domeniul";
            label1.Font = new Font("Times New Roman", 14);
            label1.Text = "";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            setQuote(0, 14);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setQuote(15, 29);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setQuote(30, 44);

        }
    }
}