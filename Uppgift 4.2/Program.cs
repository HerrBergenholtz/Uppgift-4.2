using System;

namespace Uppgift_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int störstaTal = 0;
            bool fortsätt = true;

            while (fortsätt == true) 
            {
                Console.WriteLine("Skriv in ett heltal eller avsluta genom att skriva \"n\".");
                string svar = Console.ReadLine();

                if (svar == "n")
                {
                    fortsätt = false;
                }
                else if (störstaTal < Convert.ToInt32(svar))
                {
                    störstaTal = Convert.ToInt32(svar);
                }
            }

            Console.WriteLine("Det största talet som du skrev in är: " + störstaTal + ".");
            Console.ReadKey();
        }
    }
}