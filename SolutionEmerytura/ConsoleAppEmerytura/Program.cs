using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmerytura
{
    class Program
    {
        const int wiekEmerytalny = 67;
        const int rokprzed = wiekEmerytalny - 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja Emerytura");

            Console.Write("Podaj imię: ");
            string imie = Console.ReadLine();
            Console.WriteLine($"Witaj {imie}!");

            Console.Write("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            if (wiek < 67)
            {
                Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} lat do emerytury");

            }
            else if (wiek == rokprzed)
                {
                    Console.WriteLine($"Zostało Ci {rokprzed} rok do emerytury");
                }
            
            else
            {
                Console.WriteLine("Jesteś emerytem.");
            }
            //Console.ReadKey(); // oczekuje na naciśnięcie dowolnego klawisza
            
        }
    }
}
