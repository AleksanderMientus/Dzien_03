using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasaStatyczna
{
    /// <summary>
    /// Klasa statyczna. 
    /// Jedna na cały program.
    /// </summary>
    static class Utils
    {
        public static string hostname = "localhost";
        public static int portNumeber = 1234;

        public static int GetMaxValue(params int[] args)
        {
            return args.Max();
        }
    }
}
