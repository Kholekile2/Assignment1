using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class NumberOfBottless
    {
        public static void Sing(int numberOfBottles)
        {

            while (numberOfBottles > 2)
            {
                Console.WriteLine(numberOfBottles + " bottles of beer on the wall, " + numberOfBottles + " bottles of beer.");


                numberOfBottles--;

                Console.WriteLine("Take one down and pass it around, " + numberOfBottles + " bottles of beer on the wall.");

                Console.WriteLine();
            }


            Console.WriteLine(numberOfBottles + " bottles of beer on the wall, " + numberOfBottles + " botlle of beer.");
            numberOfBottles--;

            Console.WriteLine("Take one down and pass it around, " + numberOfBottles + " bottle of beer on the wall.");

            Console.WriteLine();
            Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
            Console.WriteLine();


            Console.WriteLine("BUY MORE BEER");
        }

    

    }

}


