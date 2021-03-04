using System;

namespace Methodes
{
    class Program
    {
        static void Main(string[] args)
        {

            bool running = true;
            double getal1, getal2;

            while (running)
            {
                //Eerste getal opvragen
                getal1 = InputDouble();
                Console.WriteLine($"Je eerste getal is {getal1}");
                
                //Teken opvragen
                char teken = InputChar();
                
                Console.WriteLine($"Je teken is {teken}");
                
                //Tweede getal opvragen
                getal2 = InputDouble();
                Console.WriteLine($"Je eerste getal is {getal2}");

                //Totaal afdrukken
                Console.WriteLine($"Je totaal is: {Calc(getal1, getal2, teken)}");

                //Afsluiten ja of nee
                running = StopRunning();
                
            }           
        }

        static bool StopRunning() 
        {
            string antwoord = String.Empty;
            Console.Write("Type stop als je wilt stoppen: ");
            antwoord = Console.ReadLine();
            if (antwoord.ToLower() == "stop")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static double InputDouble()
        {

            double i;
            Console.Write("Input getal:");
            string getal = Console.ReadLine();
            if (double.TryParse(getal, out i))
            {
                i = Convert.ToDouble(getal);
                return i;
            }
            else
            {
                Console.Write("Dat was geen getal\n");
                return InputDouble(); 
            }
            
        }
        static char InputChar()
        {

            Console.Write("Input teken:");
            string teken = Console.ReadLine();
            char tekenChar;
            if (char.TryParse(teken, out tekenChar))
            {
                tekenChar = Convert.ToChar(teken);
                if (tekenChar != '+' && tekenChar != '-' && tekenChar != '*' && tekenChar != '/' && tekenChar != '^')
                {
                    Console.WriteLine("Geef aub, +, -, *, / of ^ in");
                    return InputChar();
                }
                return tekenChar;
            }
            else
            {
                Console.WriteLine("Geef aub, +, -, *, / of ^ in");
                return InputChar();
            }
        }

        static double Calc(double getal1,double getal2,char teken)
        {
            double totaal = 0;
            if (teken == '+')
            {
                totaal = getal1 + getal2;
                return totaal;
            }
            else if (teken == '-')
            {
                totaal = getal1 - getal2;
                return totaal;
            }
            else if (teken == '*')
            {
                totaal = getal1 * getal2;
                return totaal;
            }
            else if (teken == '/')
            {
                totaal = getal1 / getal2;
                return totaal;
            }
            else if (teken == '^')
            {
                totaal = Math.Pow(getal1,getal2);
                return totaal;
            }
            else
            {
                return 404;
            }
        }

    }
}
