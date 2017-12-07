using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex1_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push("Joelle");
            stack.Push("sally");
            stack.Push("bob");


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();

            Console.ReadLine();
        }
    }
}
