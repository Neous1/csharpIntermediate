using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Stack
    {
        public void Push(object obj)
        {
            
        }

        public object Pop()
        {
            return 0;
        }

        private void Clear()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            foreach (object obj in stack)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(stack.Pop());

        }
    }
}
