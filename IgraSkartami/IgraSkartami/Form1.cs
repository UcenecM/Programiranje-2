namespace IgraSkartami
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "";
            for(int k= 0; k< 5; k++)
            {
                Karta nakljuèna = new Karta((Barve)r.Next(4), (Vrednosti)r.Next(1, 14));
                s += nakljuèna.Ime + Environment.NewLine;
            }
          
            MessageBox.Show(s);
        }
    }
}