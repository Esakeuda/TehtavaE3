using System;

namespace EtuJaSukunimiKirjain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä sana: ");
            string sana = Console.ReadLine();

            if (sana.Length < 2)
            {
                Console.WriteLine("Sana on liian lyhyt vaihdettavaksi.");
            }
            else
            {
                char ensimmäinenKirjain = sana[0];
                char viimeinenKirjain = sana[sana.Length - 1];

                // Luo uusi sana vaihtamalla ensimmäinen ja viimeinen kirjain
                string uusiSana = viimeinenKirjain + sana.Substring(1, sana.Length - 2) + ensimmäinenKirjain;

                Console.WriteLine("Uusi sana: " + uusiSana);
            }
        }
    }
}

