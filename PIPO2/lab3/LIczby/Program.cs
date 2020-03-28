using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIczby
{
    class Program
    {
        static void Main(string[] args) {
            liczby L1 = new liczby(2, 3, 4);
            liczby L2 = new liczby(5, 2, 9);

            L1.A = 3;
            L1.B = 4;
            L1.C = 5;

            L2.A = 8;
            L2.C = 13;

            Console.WriteLine("Liczby L1");
            Console.WriteLine("A: " + L1.A + " B: " + L1.B + " C: " + L1.C);
            Console.WriteLine("Liczby L2");
            Console.WriteLine("A: " + L2.A + " B: " + L2.B + " C: " + L2.C);

            Lepsze_liczby LL1 = new Lepsze_liczby(5, 2, 9,4);
            LL1.A = 6;
            LL1.B = 3;
            LL1.C = 11;
            LL1.D = 10;

            Console.WriteLine("Liczby LL1");
            Console.WriteLine("A: " + LL1.A + " B: " + LL1.B + " C: " + LL1.C + " D: " + LL1.D);
            Console.ReadKey();
        }
    }
}
