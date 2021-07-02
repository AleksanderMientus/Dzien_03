using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figury
{
    //sealed class Prostokat : Figura, IFigura  // zablokowanie dziedziczenia z tej klasy - sealed
    class Prostokat : Figura, IFigura
    {
        private double bokA;
        private double bokB;

        public Prostokat(double a, double b)
        {
            bokA = a; bokB = b;
        }

        public double ObliczObwod()
        {
            throw new NotImplementedException();
        }

        public double ObliczPole()
        {
            throw new NotImplementedException();
        }

        public bool CzyKwadrat()
        {
            return bokA == bokB;
        }
    }
}
