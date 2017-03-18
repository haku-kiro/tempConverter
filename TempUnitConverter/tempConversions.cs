using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempUnitConverter
{
    public class tempConversions
    {
        //delegate for temp conv useage
        public delegate double conv(double val); //can ppotentially store a list of methods, with this sig

        //properties or state


        //methods or behaviour
        public static double fromCtoF(double cIn)
        {
            return (cIn * 1.8) + 32;
        }

        public static double fromFtoC(double fIn)
        {
            return (fIn - 32) * 5 / 9;
        }

        //make a method that the delegate can contain so that it returns either C or F

        public static void something()
        {
            Console.WriteLine("Something");
        }
        //events
    }

    public delegate void test();
}
