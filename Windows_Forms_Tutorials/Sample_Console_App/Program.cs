using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.name);
        }

        //// A sample about Radom class
        //// The following example creates a single random generator and call its NextBytes, Next, and NextDouble
        //// methods to generate sequences of random numbers within different ranges.
        //static void Main(string[] args)
        //{
        //    // Instantiate random number generator using system-supplied value as seed
        //    var rand = new Random();

        //    //// Generate and display 5 random byte (integer) values
        //    //var bytes = new byte[5];
        //    //rand.NextBytes(bytes);
        //    //Console.WriteLine("Five random byte values:");
        //    //foreach (var item in bytes)
        //    //{
        //    //    Console.Write("{0, 5}", item);
        //    //}
        //    //Console.WriteLine();
        //    //// -> OUTPUT:
        //    ////Five random byte values:
        //    ////56  164  238  124   76

        //    //// Generate and display 5 random integers
        //    //Console.WriteLine("Five random integer values:");
        //    //for (int i = 0; i < 5; i++)
        //    //{
        //    //    //Console.Write($"{rand.Next()} ");
        //    //    Console.Write("{0,15:N0}", rand.Next());
        //    //}
        //    //Console.WriteLine();
        //    //// -> OUTPUT:
        //    ////Five random integer values:
        //    ////1,419,969,413    534,276,553  1,304,236,915  1,515,200,137    444,375,257
        //    ///

        //    //// Create and display 5 random integers between 0 and 100
        //    //Console.WriteLine("Five random integers between 0 and 100:");
        //    //for (int i = 0; i < 5; i++)
        //    //{
        //    //    Console.Write($"{rand.Next(101)} ");
        //    //}
        //    //Console.WriteLine();
        //    //// -> OUTPUT:
        //    ////Five random integers between 0 and 100:
        //    ////54 13 84 73 5

        //    //// Create and display five random integers from 50 to 100
        //    //Console.WriteLine("Five random integers from 50 to 100:");
        //    //for (int i = 0; i < 5; i++)
        //    //{
        //    //    Console.Write($"{rand.Next(50, 101)} ");
        //    //}
        //    //Console.WriteLine();
        //    //// -> OUTPUT:
        //    ////Five random integers from 50 to 100:
        //    ////70 75 79 57 86

        //    //// Generate and display 5 random floating point values from 0 to 1
        //    //Console.WriteLine("Five random doubles:");
        //    //for (int i = 0; i < 5; i++)
        //    //{
        //    //    Console.Write("{0,8:N3}", rand.NextDouble());
        //    //}
        //    //Console.WriteLine();
        //    //// -< OUTPUT:
        //    ////Five random doubles:
        //    ////   0.956   0.653   0.232   0.131   0.193

        //    // Generate and display 5 random floating point values from 0 to 5
        //    Console.WriteLine("Five random doubles between 0 and 5:");
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.Write("{0,8:N3}", rand.NextDouble() * 5);
        //    }
        //    Console.WriteLine();
        //    // -> OUTPUT:
        //    //Five random doubles between 0 and 5:
        //    //   0.305   2.578   3.963   0.372   2.131
        //}
    }
}
