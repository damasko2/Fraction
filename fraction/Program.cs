using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace fraction.K
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(20, 45);

            Fraction f2 = new Fraction(12, 23);

            int num = 5;
            double d = 3.45;
            //Fraction f3 = f1 / d;
            Fraction f3 = d / f1;
            //Fraction f3 = f1 / f2;

            Console.WriteLine(f3.ToString());
        }
    }
}
