using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    public class Stopwach
    {
        private DateTime _begin;

        public DateTime Begin
        {
            get { return _begin; }
            set { _begin = value; }
        }

        public DateTime End { get; set; }

        public DateTime Start()
        {

            _begin = DateTime.Now;
            return _begin;
        }

        public DateTime Stop()
        {
            End = DateTime.Now;
            return End;
        }
    }
                /*
            Design a class called Stopwatch. 
            The job of this class is to simulate a stopwatch. 
            It should provide two methods: Start and Stop. 
            We call the start method first, and the stop method next.
            Then we ask the stopwatch about the duration between start and stop. 
            Duration should be a value in TimeSpan. 
            Display the duration on the console.
            We should also be able to use a stopwatch multiple times. 
            So we may start and stop it and then start and stop it again. 
            Make sure the duration value each time is calculated properly.
            We should not be able to start a stopwatch twice in a row 
            (because that may overwrite the initial start time). 
            So the class should throw an InvalidOperationException if its started twice. 
            */
    class Program
    {

        static void Main(string[] args)
        {
            var stopwatch = new Stopwach();


            Console.WriteLine(" Enter A to Start the stopwatch");
            string a = Console.ReadLine();
            //Console.WriteLine("string is " + a);
            while (a != "x")
            {
                if (a == "a")
                {
                    stopwatch.Start();
                    Console.WriteLine("started at " + DateTime.Now.Second);
                }

                var start = stopwatch.Start();
                //Task.Delay(50000000);

                //Console.WriteLine("Type this:");
                Console.WriteLine();
                //Console.WriteLine("Lorem Ipsum is simply dummy " +
                //                  "text of the printing and typesetting industry. " +
                //                  "Lorem Ipsum has been the industry's standard " +
                //                  "dummy text ever since the 1500s, when an unknown " +
                //                  "printer took a galley of type and scrambled it to " +
                //                  "make a type specimen book. It has survived not only " +
                //                  "five centuries, but also the leap into electronic " +
                //                  "typesetting, remaining essentially unchanged. " +
                //                  "It was popularised in the 1960s with the release of " +
                //                  "Letraset sheets containing Lorem Ipsum passages, " +
                //                  "and more recently with desktop publishing software " +
                //                  "like Aldus PageMaker including versions of " +
                //                  "Lorem Ipsum");

                //var s = Console.ReadLine();

                Console.WriteLine("Press S to Stop the stopwatch");

                string s = Console.ReadLine();
                //Console.WriteLine("string is " + s);

                if (s == "s")
                {
                    stopwatch.Stop();
                    Console.WriteLine("stopping at " + DateTime.Now.Second);
                }
                var end = stopwatch.Stop();

                TimeSpan duration = (end - start).Duration();

                Console.WriteLine("Time ellapsed is {0}", duration);
                Console.WriteLine();

                Console.WriteLine("Enter A to Start or X to exit");
                a = Console.ReadLine();
                if (a == "x")
                {
                    Console.WriteLine("Exit");
                }
                
            }

            

        }
    }
}
