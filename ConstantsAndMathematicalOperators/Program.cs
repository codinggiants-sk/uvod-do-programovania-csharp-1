using System;

namespace ConstantsAndMathematicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cvičenie 1
            string favoriteHolidays = "Monaco";
            int catAge = 12;
            Console.WriteLine("Naj dovolenka: {0}. Vek mačky: {1}", favoriteHolidays, catAge);

            favoriteHolidays = "Rhodes";
            catAge = 17;
            Console.WriteLine("Naj dovolenka: {0}. Vek mačky: {1}", favoriteHolidays, catAge);

            const string worstHolidays = "Látky-Prašivá";
            const int shoeSize = 44;
            Console.WriteLine("Zlá dovolenka: {0}. Veľkosť topánky: {1}", worstHolidays, shoeSize);

            //This is an error because we can't assign a new value to a constant
            //worstHolidays = "Londýn";
            //Same here
            //shoeSize = 46;
            Console.WriteLine("Zlá dovolenka: {0}. Veľkosť topánky: {1}", worstHolidays, shoeSize);

            Console.WriteLine("Stlač ľubovoľnú klávesu");
            Console.ReadKey();


            //Cvičenie 2
            const int d = 5;
            const int e = 10;
            const int f = 21;

            int result = 4 * d + 3 - e * 7 - f;
            Console.WriteLine("Výsledok: {0}", result);

            Console.WriteLine("Stlač ľubovoľnú klávesu");
            Console.ReadKey();


            //Cvičenie 3
            int h;
            int a, b;
            Console.WriteLine("Zadaj dĺžku hrany A lichobežníka: ");
            a = int.Parse(Console.ReadLine()); // Všetko čo napíšeme do konzoly pri príkaze Console.ReadLine() je chápané ako reťazec znakov
                                               // teda text. Ak chceme interpretovať načítaný text povedzme ako číslo musíme ho prekonvertovať
                                               // teda načítať do číselnej premennej. Potom s načitanou hodnotou môžeme ďalej pracovať ako s
                                               // číslom. 

            Console.WriteLine("Zadaj dĺžku hrany B lichobežníka: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj výšku lichobežníka: ");
            h = int.Parse(Console.ReadLine());

            double area = 0.5 * h * (a + b);
            Console.WriteLine("Plocha lichobežníka je: {0}", area);

            Console.WriteLine("Stlač ľubovoľnú klávesu");
            Console.ReadKey();

            //Cvičenie 4
            const float PI = 3.14f;
            Console.WriteLine("Program na výpočet obodu kruhu!");
            Console.WriteLine("Zadajte polomer: ");
            int radius = int.Parse(Console.ReadLine());
            float circumference = 2 * PI * radius;
            Console.WriteLine("Obvod kruhu je: {0}", circumference);

            Console.WriteLine("Stlač ľubovoľnú klávesu");
            Console.ReadKey();

            //Cvičenie 5 (matematické operácie)
            Console.WriteLine("Zadaj teplotu v stupňoch Fahrenheita");
            float degreesFahr = int.Parse(Console.ReadLine());
            float degreesCel = 5f / 9f * (degreesFahr - 32);
            Console.WriteLine("Teplota v stupňoch celzia: {0}", degreesCel);

            Console.WriteLine("Stlač ľubovoľnú klávesu");
            Console.ReadKey();
        }
    }
}
