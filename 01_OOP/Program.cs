using OOP.Figury;
using OOP.KlasaAbstrakcyjna;
using OOP.KlasaStatyczna;
using OOP.Przeciazanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trojkat trojkat1 = new Trojkat(2.3, 3);
            //Trojkat trojkat2 = new Trojkat(3, 3, 3);

            //Figura figura = new Figura();

            //Prostokat prostokat1 = new Prostokat(3, 2);
            //Console.WriteLine(prostokat1.CzyKwadrat());

            //Kwadrat kwadrat1 = new Kwadrat(10);
            //Console.WriteLine(kwadrat1.CzyKwadrat());

            //AbstractProduct product = new AbstractProduct(); - to nie zadziała / klasa abstrakcyjna
            //Product product = new Product("Kluski", 3.99, "867576546564");
            //product.ShowInfo();

            //Wektor wektor1 = new Wektor(-1, 1);
            //Wektor wektor2 = new Wektor(1, -1);
            //Wektor wektor3 = wektor1.Add(wektor2);
            //wektor3.Print();

            //wektor3 = wektor1 + wektor2;
            //wektor3.Print();

            //wektor3 = wektor1 + 3.5;
            //wektor3.Print();

            // Korzystanie z klasy statycznej / jedna klasa na cały program
            Console.WriteLine("{0} - {1}", Utils.hostname, Utils.portNumeber);
            Console.WriteLine(Utils.GetMaxValue(-1, 10, 1, 12));
            Console.WriteLine(Utils.GetMaxValue(100,99,98));
            Console.WriteLine(Utils.GetMaxValue(100,99));

            Console.ReadKey();

        }
    }
}
