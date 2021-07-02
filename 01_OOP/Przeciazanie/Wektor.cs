using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Przeciazanie
{
    class Wektor
    {
        public double x;
        public double y;

        public Wektor(double x, double y)
        {
            this.x = x; this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("X={0}, Y={1}", x, y);
        }

        public Wektor Add(Wektor w)
        {
            return new Wektor(x + w.x, y + w.y);
        }

        public static Wektor operator +(Wektor w1, Wektor w2)
        {
            return new Wektor(w1.x + w2.x, w1.y + w2.y);
        }

        public static Wektor operator +(Wektor w1, double n)
        {
            return new Wektor(w1.x + n, w1.y + n);
        }

        public static Wektor operator +(double n, Wektor w1)
        {
            return new Wektor(w1.x + n, w1.y + n);
        }
    }
}
