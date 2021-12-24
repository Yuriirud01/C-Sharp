using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance 
{
    public class Stack
    {
        private List<object> _stack = new List<object>();
        public void GetStack()
        {
            for (var i = _stack.Count() - 1; i >= 0; i--)
            {
                Console.Write(_stack[i] + ", ");
            }
        }

        public void Push(object obj)
        {
            this._stack.Add(obj);
        }

        public object Pop()
        {
            if (this._stack.Count != 0)
            {
                object last = this._stack.Last();
                this._stack.RemoveAt(_stack.Count - 1);
                return last;
            }
            else
            {
                throw new InvalidOperationException("Sosu chlen IURIY");
            }
            
        }

        public void Clear()
        {
            while(this._stack.Count > 0)
            {
                this._stack.RemoveAt(_stack.Count - 1);
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var my_stack = new Stack();
            my_stack.Push(1);
            my_stack.Push("hello");
            my_stack.Push(true);
            my_stack.Push(10.5f);
            Console.WriteLine(my_stack.Pop());
            my_stack.GetStack();
        }
    }
}