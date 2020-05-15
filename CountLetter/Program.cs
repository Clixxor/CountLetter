using System;

namespace CountLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welches Wort wollen Sie überprüfen?");
            string Wort = Console.ReadLine().ToLower();

            Console.WriteLine("Welchen Buchstaben suchen Sie?");
            char Buchstabe = Convert.ToChar(Console.ReadLine().ToLower());

            int Zähler = 0;
            char charToCount = Buchstabe;

            foreach (char c in Wort)
            {
                if (c == charToCount)
                {
                    Zähler++;
                }
            }

            Console.WriteLine("Die Anzahl des Buchstaben: " + Buchstabe + " ist: " + Zähler);
        }
    }
}
