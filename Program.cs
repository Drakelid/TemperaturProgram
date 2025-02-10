using System;

namespace TemperaturProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Spør brukeren om å oppgi en temperatur
            Console.Write("Skriv inn temperaturen: ");
            string input = Console.ReadLine();

            // Forsøk å konvertere input til en double
            if (!double.TryParse(input, out double temperatur))
            {
                Console.WriteLine("Ugyldig input. Vennligst oppgi et tall.");
                return;
            }

            // Sjekk temperaturverdien og skriv ut passende melding
            if (temperatur < 0)
            {
                Console.WriteLine("Det er iskaldt!");
            }
            else if (temperatur >= 0 && temperatur <= 20)
            {
                Console.WriteLine("Det er kaldt.");
            }
            else if (temperatur > 20 && temperatur <= 30)
            {
                Console.WriteLine("Det er behagelig.");
            }
            else // temperatur > 30
            {
                Console.WriteLine("Det er varmt!");
            }
        }
    }
}
