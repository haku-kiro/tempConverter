using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempUnitConverter;

namespace testPlatform
{
    class Program
    {
        static void Main(string[] args)
        {

           tempConversions.conv handler = new tempConversions.conv(tempConversions.fromCtoF); //creating the delegate giving it the ctof default

           //test handlerFromNamespace = new test(tempConversions.something); //namespace delegate

            Console.WriteLine("Make a choice of unit of temp to convert to");
            //promt user:
            Console.WriteLine("Convert from: ");
            string sFrom = (Console.ReadLine()).ToUpper(); //just making it upper
            Console.WriteLine("Convert to: ");
            string sTo = Console.ReadLine().ToUpper(); 

            double tempIn;
            double tempOut;

            //determine which formula to apply based on from and to var
            if (sFrom == "C" && sTo == "F")
            {
                Console.WriteLine("Please enter a temp in C:");
                if (double.TryParse(Console.ReadLine(), out tempIn))
                {
                    tempOut = handler(tempIn); //delegate by default has the ctof method
                    Console.WriteLine("The temp in F is: {0} F", tempOut); //do some error checking here
                }
                else
                {
                    Console.WriteLine("You entered an invalid value");
                }
            }
            else if (sFrom == "F" && sTo == "C")
            {
                handler -= tempConversions.fromCtoF; //take out the cToF method (not using this conversion)
                handler += tempConversions.fromFtoC; //add the f to c conversion
                Console.WriteLine("Please enter a temp in F");
                if (double.TryParse(Console.ReadLine(), out tempIn))
                {
                    tempOut = handler(tempIn);
                    Console.WriteLine("The temp in C is: {0} C", tempOut);
                }
            }
            else
            {
                Console.WriteLine("You have entered an invalid input.");
            }

            Console.ReadKey(); //so that it doesnt close ye (WAITS FOR INPUT)

        }
    }
}



//notes, maybe mod the delegate so that it is more useful in a sense that the class has methods that cw the C or the F for ex
//so you can execute the delegate at the end - as a one liner