using System;

namespace PrepocetEUR
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal kurz = 26.05m;
            Console.WriteLine("Zadaj sumu v eurách, ktorú chceš prepočítať na české koruny.");
            decimal sumaEur = decimal.Parse(Console.ReadLine());
            decimal sumaCZK = sumaEur * kurz;
            Console.WriteLine("Suma {0} eur je {1} czk", sumaEur,sumaCZK);
            Console.ReadKey();

        }
    }
}
