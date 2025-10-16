namespace Strukture
{
    internal class Program
    {
        struct Vektor
        {
            public double x, y, z;
            public override string ToString()
            {
                return "(" + x + ", " + y + ", " + z + ")";
            } 
            public Vektor(double x1, double y1, double z1)
            {
                x = x1; y = y1; z = z1;
            }
            public Vektor(Vektor v)
            {
                x = v.x; y = v.y; z = v.z;
            }


            public static Vektor operator +(Vektor levi, Vektor desni)
            {
                Vektor r = new Vektor();
                r.x = levi.x + desni.x;
                r.y = levi.y + desni.y;
                r.z = levi.z + desni.z;
                return r;
            }
            public static Vektor operator *(double l, Vektor d)
            {
                Vektor r = new Vektor();
                r.x = l * d.x;
                r.y = l * d.y;
                r.z = l * d.z;
                return r;

            }
        }
        static void Main(string[] args)
        {
            Vektor v1;
            v1.x = 3;
            v1.y = 2;
            v1.z = 0;
            Console.WriteLine(v1.ToString());
            Vektor v2 = new Vektor();
            Console.WriteLine(v2.ToString());
            Vektor v3 = v1 + v2;
        }
    }
}
