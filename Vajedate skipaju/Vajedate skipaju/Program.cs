namespace Vajedate_skipaju
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1) Napišite stavke v C# s katerimi
a) Preverite ali je vrednost spremenljivke števec večja od 10. Če je, izpišite "Števec je večji od 
10".
             //int števec = 13;
            //if (števec > 10)
            //{
            //    Console.WriteLine("Števec je večji od 10");
            //}
b) Seštejete v spremenljivko sum vsa liha števila med 1 in 99 z uporabo for zanke
*/
            //int sum = 0;
            //for (int k = 1; k<=99; k= k+2)
            //{
            //    sum += k; 
            //}
            //Console.WriteLine("Vsota je "+sum);
            //c) Seštejete v spremenljivko sum vsa liha števila med 1 in 99 z uporabo do-while zanke
            //            int sum1 = 0;
            //            int števec = 1;
            //            do
            //            {
            //                sum1 += števec;
            //                števec += 2;
            //            } while (števec <= 99);
            //            Console.WriteLine("vsota je sum1 " + sum1);

            //d) Izpišete cela števila od 1 do 20 na zaslon z uporabo while zanke. V eni vrstici naj bo samo 5 
            //števil*/
            int š = 1;
            while (š <=20)
            {
                Console.Write("{0,4}", š);
                if (š%5 == 0)
                {
                    Console.WriteLine();
                }
                š++;
            }




        }
    }
}
