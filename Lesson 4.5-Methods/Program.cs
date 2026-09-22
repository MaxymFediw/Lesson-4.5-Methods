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
            int bugs;

            Console.WriteLine("How many bugs do you want? (A full number, please.)");

            if (Int32.TryParse(Console.ReadLine(), out bugs))
            {
                //int number = Gen.Next(bugs);
            }

            else 
            {
                Console.WriteLine("I guess, bro. You're gonna get 8 bugs, big guy.");
                bugs = 8;
            }

            Console.WriteLine("Press ENTER For A Joke.");

            Console.ReadLine();

            Joke(bugs);










        }

        public static void Joke(int numBugs) 
        {
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine((numBugs - 1) + " little bugs in the code.");


        }
    }
}
