namespace IgraSkartami
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        Kup kup1;
        Kup kup2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //koliko kart prika�em
            int �tkart = r.Next(1, 11);
            kup1 = new Kup(new Karta[] { });
            for (int k = 0; k < �tkart; k++)
            {
                kup1.Add(new Karta((Barve)r.Next(4), (Vrednosti)r.Next(1, 14)));
            }
            kup1.Sort();
            listNak.Items.Clear();
            for (int k = 0; k < kup1.Count; k++)
            {
                listNak.Items.Add(kup1.ImenaKart()[k]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int �tkart = r.Next(1, 11);
            kup2 = new Kup();
            kup2.Sort();
            listCel.Items.Clear();
            for (int k = 0; k < kup2.Count; k++)
            {
                listCel.Items.Add(kup2.ImenaKart()[k]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kup1.Me�aj();
            listNak.Items.Clear();
            for (int k = 0; k < kup1.Count; k++)
            {
                listNak.Items.Add(kup1.ImenaKart()[k]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kup2.Me�aj();
            listCel.Items.Clear();
            for (int k = 0; k < kup2.Count; k++)
            {
                listCel.Items.Add(kup2.ImenaKart()[k]);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    String rez = "";
        //    List<Karta> kup = new List<Karta>();
        //    for(int k= 0; k< 5; k++)
        //    {
        //        Karta naklju�na = new Karta((Barve)r.Next(4), (Vrednosti)r.Next(1, 14));
        //        kup.Add(naklju�na);
        //        rez += naklju�na.Ime + Environment.NewLine;
        //    }
        //    kup.Sort();
        //    rez += Environment.NewLine + "Urejen kup" + Environment.NewLine;
        //    for(int k=0; k<5; k++)
        //    {
        //        rez += kup[k].Ime + Environment.NewLine;
        //    }
        //    MessageBox.Show(rez);
        //}
    }
}