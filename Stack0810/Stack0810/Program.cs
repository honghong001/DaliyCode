using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack0810
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            Console.WriteLine("===============PUSH===============");
            
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("TOP OF THE STACK:" + stack.Peek());

            Console.WriteLine("===============POP===============");

            stack.Pop();

            Console.WriteLine("TOP OF THE STACK " + stack.Peek());

            Console.WriteLine("===============CLEAR===============");

            stack.Clear();
        }
    }
}


