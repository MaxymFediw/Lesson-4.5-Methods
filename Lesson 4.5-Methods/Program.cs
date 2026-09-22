using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_4._5_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER For A Joke.");

            Console.ReadLine();

            Joke(50);










        }

        public static void Joke(int numBugs) 
        {
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine((numBugs++) + " little bugs in the code.");


        }
    }
}
