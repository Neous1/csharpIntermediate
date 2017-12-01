using System;
using System.Collections;

namespace Ex1_inheritance
{
    public class Stack
    {
        readonly ArrayList _myStack = new ArrayList();
        public void Push(object obj)
        {
            _myStack.Add(obj);
        }

        public object Pop()
        {
            var index = _myStack.Count-1;
            var value = _myStack[index];
            Console.WriteLine("index " +value);


            _myStack.RemoveAt(index);


            return value;
            
        }

        public void Clear()
        {
            
        }
    }
}