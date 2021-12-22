using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczba_parzysta
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Witaj. Sprawdzam parzystość liczby.");
                while (true)
                {
                    Console.WriteLine("Wprowadź liczbę.");
                    Console.WriteLine(ResultEvenString(GetValidateUserNumber()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
        private static int GetValidateUserNumber()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(),out result))
            {
                Console.WriteLine("Wprowadzono nieprawidłowe dane, spróbuj ponownie.");
            }
            return result;
        }

        private static bool Parity(int inputNumber)
        {
            return inputNumber % 2 == 0;
        }

        private static string ResultEvenString(int userNumber)
        {
            if (Parity(userNumber))
                return "Liczba parzysta\n";
            else return "Liczba nieparzysta\n";
        }
    }
}
