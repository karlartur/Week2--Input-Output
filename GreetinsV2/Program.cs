using System;

namespace GreetinsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm küsib kasutaja perekonnanime
            //programm tervitab kasutajat, kasutades neid andmeid
            Console.WriteLine("Mis su nimi on?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Mis su perekonnanimi on?");
            string LastName = Console.ReadLine();
            Console.WriteLine($"Hello, {FirstName}, {LastName}");
            Console.ReadLine();
        }
    }
}
