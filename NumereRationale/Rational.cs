using System;

namespace NumereRationale
{
    internal class Rational
    {
        private int numitor;
        private int numarator;
        

        public Rational()
        {
            numarator = 1;
            numitor = 1;
        }
        public Rational(int _numarator)
        {
            numarator = _numarator;
            numitor = 1;
        }
        public Rational (int _numarator, int _numitor)
        {
            numarator = _numarator;
            numitor = _numitor;

        }

        public static void NumitorComun(Rational nr1, Rational nr2)
        {
            int x = nr1.numitor;
            int y = nr2.numitor;
            int cmmmc;

            while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }
            cmmmc = (nr1.numitor * nr2.numitor) / x;
           
            int produs1 = cmmmc / nr1.numitor;
            int produs2 = cmmmc / nr2.numitor;

            nr1.numarator *= produs1;
            nr1.numitor *= produs1;
            
            nr2.numarator *= produs2;
            nr2.numitor *= produs2;
        }

        public static Rational FormaIreductibila(Rational nr)
        {          
            int a = Math.Abs(nr.numarator);
            int b = Math.Abs(nr.numitor);

            while (a != b)
            {
                if (a > b)
                    a = a - b;
                if (b > a)
                    b = b - a;
            }
            nr.numarator /= b;
            nr.numitor /= b;

            return nr;
        }

        public static void Adunare(Rational nr1, Rational nr2)
        {
            int numarator;


            if (nr1.numitor == nr2.numitor)
            {
                numarator = nr1.numarator + nr2.numarator;
            }
            else
            {
                NumitorComun(nr1, nr2);
                numarator = nr1.numarator + nr2.numarator;
            }

            Rational adunare = new Rational(numarator, nr1.numitor);
            FormaIreductibila(adunare);
            Console.Write("Adunare: ");
            Rational.Print(adunare);          
        }

        public static void Scadere(Rational nr1, Rational nr2)
        {
            int numarator;
            

            if (nr1.numitor == nr2.numitor)
            {
                numarator = nr1.numarator - nr2.numarator;
            }
            else
            {
                NumitorComun(nr1, nr2);
                numarator = nr1.numarator - nr2.numarator;
            }

            if (numarator != 0)
            {
                int numitor = nr1.numitor;
                Rational scadere = new Rational(numarator, numitor);
                FormaIreductibila(scadere);
                Console.Write("Scadere: ");
                Rational.Print(scadere);
            }
            else Console.WriteLine("Scaderea nu se poate face.");

        }

        public static void Inmultire(Rational nr1, Rational nr2)
        {
            int numarator;
            int numitor;

            numarator = nr1.numarator * nr2.numarator;
            numitor = nr1.numitor * nr2.numitor;
            Rational inmultire = new Rational(numarator,numitor);
            FormaIreductibila(inmultire);
            Console.Write("Inmultire: ");
            Rational.Print(inmultire);

        }

        public static void Impartire(Rational nr1,Rational nr2)
        {
            int numarator;
            int numitor;

            numarator = nr1.numarator * nr2.numitor;
            numitor = nr1.numitor * nr2.numarator;

            Rational impartire = new Rational(numarator, numitor);
            FormaIreductibila(impartire);
            Console.Write("Impartire: ");
            Rational.Print(impartire);
        }

        public static void RidicareLaPutere(Rational nr1, int putere)
        {
            int numarator = (int)Math.Pow(nr1.numarator, putere);
            int numitor = (int)Math.Pow(nr1.numitor,putere);
            Rational ridicarelaputere = new Rational(numarator,numitor);
            FormaIreductibila(ridicarelaputere);
            Console.Write("Ridicare la puterea {0}: ",putere);
            Rational.Print(ridicarelaputere);
        }

        public static void Max(Rational nr1, Rational nr2)
        {
            NumitorComun(nr1, nr2);
            
            Console.Write("Numarul mai mare este: ");
            if (nr1.numarator > nr2.numarator)
                Rational.Print(nr1);
            else Rational.Print(nr2);
        }

        public static void Min(Rational nr1, Rational nr2)
        {
            NumitorComun(nr1, nr2);

            Console.Write("Numarul mai mic este: ");
            if (nr1.numarator < nr2.numarator)
                Rational.Print(nr1);
            else Rational.Print(nr2);
        }

        public static bool IsEqual(Rational nr1,Rational nr2)
        {
            FormaIreductibila(nr1);
            FormaIreductibila(nr2);

            if ((nr1.numarator == nr2.numarator) && (nr1.numitor == nr2.numitor))
                return true;
            else return false;
        }

        public static void IsZero(Rational nr)
        {
            if (nr.numarator == 0 || nr.numitor == 0)
                Console.WriteLine("Nu se pot efectua calculele cu 0");            
        }

        public static void Print(Rational nr)
        {
            System.Console.WriteLine("{0}/{1}",nr.numarator,nr.numitor);
        }
    }
}