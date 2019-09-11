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
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja EMERYTURA");

            Console.Write("Podaj imię: ");
            string imie = Console.ReadLine();
            Console.WriteLine($"Witaj {imie}!");

            Console.Write("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());

            if (wiek < wiekEmerytalny)
            {
                if ((wiek == wiekEmerytalny - 1))
                {
                    Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} rok do emerytury");
                }
                else if ((wiek == wiekEmerytalny - 2) || (wiek == wiekEmerytalny - 3) || (wiek == wiekEmerytalny - 4))
                {
                    Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} lata do emerytury");
                }
                else if ((wiek != wiekEmerytalny - 1))
                {
                    Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} lat do emerytury");
                }
            }
            else
            {
                Console.WriteLine("Jesteś emerytem.");
            }
        }
    }
}
