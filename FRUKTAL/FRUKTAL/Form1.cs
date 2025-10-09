namespace FRUKTAL
{
    public partial class Form1 : Form
    {
        private double x;
        private double y;
        private double a; //kot poremikanja gere na kot x
        private int UmeriX(double xr)
        {
            return (int)Math.Round(xr * pictureBox1.Width);
        }
        private int UmeriY(double yr)
        {
            return (int)Math.Round(pictureBox1.Height - yr * pictureBox1.Height);
        }
        public void ObratLevo(double kot)
        {
            a += kot;
        }
        public void Premik(double d, Graphics g)
        {
            double xstari = x;
            double ystari = y;
            x = d * Math.Cos(a*Math.PI/180) + xstari;
            y = d * Math.Sin(a*Math.PI / 180) + ystari;
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, UmeriX(xstari), UmeriY(ystari), UmeriX(x), UmeriY(y));
        }
        public void Koch(int n, double korak, Graphics g)
        {
            if (n == 0)
            {
                Premik(korak, g);
                return;
            }
            Koch(n - 1, korak, g);
            ObratLevo(60);
            Koch(n - 1, korak, g);
            ObratLevo(-120);
            Koch(n - 1, korak, g);
            ObratLevo(60);
            Koch(n - 1, korak, g);
        
        }

        public void FuktalDrevo(int n, double x, double y, double a, double korak, Graphics g)
        {
            if (n == 0)
                return;

            // Shrani trenutno stanje
            double xStaro = this.x;
            double yStaro = this.y;
            double aStaro = this.a;

            // Nastavi zaèetne koordinate in kot
            this.x = x;
            this.y = y;
            this.a = a;

            // Nariši glavno vejo
            Premik(korak, g);

            // Shrani novo konèno toèko
            double xNova = this.x;
            double yNova = this.y;

            // Rekurzivno nariši levo in desno vejo
            FuktalDrevo(n - 1, xNova, yNova, a + 45, korak * 0.65, g); // levo
            FuktalDrevo(n - 1, xNova, yNova, a, korak*(1-0.65),  g); // narovnost
            FuktalDrevo(n - 1, xNova, yNova, a - 45, korak * 0.65, g); // desno

            // Povrni staro stanje
            this.x = xStaro;
            this.y = yStaro;
            this.a = aStaro;
        }



        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //x = 0.5;
            //y = 0;
            //a = 30;
            //Premik(0.2, g);
            //ObratLevo(60);
            //Premik(0.2, g);
            //ObratLevo(60);
            //Premik(0.2, g);
            //ObratLevo(60);
            //Premik(0.2, g);
            //x = 0.5;
            //y = 0.5;
            //a = 0;
            //Random r = new Random();
            //for(int k= 0; k<1000; k++)
            //{
            //    Premik(0.01, g);
            //    ObratLevo(r.Next(360));
            //}

            //KROCH AHH KLIC SNEŽINKA
            //x = 0.1;
            //y = 0.7;
            //a = 0;
            //int n = 3;
            //double korak = 1 / Math.Pow(3, n) -0.01;
            //Koch(n, korak, g);

            //a = -120;
            //Koch(n, korak, g);
            //a = -240;
            //Koch(n, korak, g);

            //FRUKTALNO DREVO POKLIC
            int n = 6;
            x = 0.5;
            y = 0.05;   
            a = 90;    
            double korak = 0.25;
            FuktalDrevo(n, x, y, a, korak, g);



        }
    }
}
