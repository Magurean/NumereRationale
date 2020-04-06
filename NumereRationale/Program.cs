using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereRationale
{
    class Program
    {
        static void Main()
        {

            Rational nr = new Rational(7, 3);
            Rational nr2 = new Rational(9, 8);

            Rational.IsZero(nr);
            Rational.IsZero(nr2);

            Rational.Print(nr);
            Rational.Print(nr2);
            Console.WriteLine();

            Rational.NumitorComun(nr, nr2);
            Console.WriteLine("Dupa numitor comun:");
            Console.WriteLine();
            Rational.Print(nr);
            Rational.Print(nr2);
            Console.WriteLine();

            Rational.Adunare(nr, nr2);
            Console.WriteLine();

            Rational.Scadere(nr, nr2);
            Console.WriteLine();

            Rational.Inmultire(nr, nr2);
            Console.WriteLine();

            Rational.Impartire(nr, nr2);
            Console.WriteLine();

            Rational.RidicareLaPutere(nr, 2);
            Console.WriteLine();

            Rational.RidicareLaPutere(nr2, 2);
            Console.WriteLine();

            Rational.Max(nr, nr2);
            Console.WriteLine();

            Rational.Min(nr, nr2);
            Console.WriteLine();

            Console.WriteLine("Sunt cele doua numere egale? {0}", Rational.IsEqual(nr,nr2));

            Console.ReadKey();
        }
    }
}
