using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGCStackArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20); 
            stack.Push(30);
            stack.Push(50);
            //stack.Pop();
            stack.Peek();
            
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


        }
    }
}
