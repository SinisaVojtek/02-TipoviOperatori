using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);
            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplic = Math.PI;

            Nullable <double> test= Math.PI;
            test = null;
            Console.WriteLine(test);

            Console.ReadKey();
        }
    }
}
