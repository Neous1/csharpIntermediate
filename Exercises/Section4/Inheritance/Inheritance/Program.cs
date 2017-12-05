using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            string s = Convert.ToString(stack.Pop());
 
//            foreach (object obj in stack)
//            {
//                Console.WriteLine();
//            }
//            Console.WriteLine(stack.Pop());

            //Console.WriteLine(stack.Pop());

        }
    }
}
