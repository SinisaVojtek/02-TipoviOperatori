using System;

namespace CSharp.TipoviOperatori
{
    struct S
    {
        public int a;
        public double b;
    }

    class Program
    {
        static void Main(string[] args)
        {

            var i0 = 5;
            var d0 = 5.2;
            i0 = (int)d0;

            int i1 = 5;
            double d1 = 5.2;
            i1 = (int)d1;

            var s=new S();

            Console.WriteLine("Vrijednost a:");
            s.a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vrijednost b:");
            s.b= Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();

        }
    }
}
