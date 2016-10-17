using System;

namespace CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba janko = new Student();
            
            Osoba osoba = new Osoba();

            if (janko is Osoba)
                Console.WriteLine("Janko je osoba.");
            if (osoba is Student)
                Console.WriteLine("Osoba je student.");
            if (janko is Student)
                Console.WriteLine("Janko je student.");
            if (osoba is Osoba)
                Console.WriteLine("Osoba je osoba.");
            Console.ReadKey();

        }
    }
}
