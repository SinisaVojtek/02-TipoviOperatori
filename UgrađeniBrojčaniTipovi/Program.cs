using System;

namespace CSharp.UgrađeniBrojčaniTipovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            int MaxBroj = int.MaxValue;
            Console.WriteLine("{0}",MaxBroj+1);

            int MinBroj = int.MinValue;
            Console.WriteLine("{0}",MinBroj-1);

            Console.WriteLine("Granične vrijednosti za tipove double: Max - {0} , Min - {1}", double.MaxValue, double.MinValue);

            int a = 2;
            int b = 0;
            int c=-2;

            Console.WriteLine("{0}", a / b);
            Console.WriteLine("{0}", c / b);

            Console.ReadKey();
        }
    }
}
