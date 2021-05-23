using System;
using System.Collections; //Used for stacks

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks!");

            //Creating
            Stack stack = new Stack();

            //Adding
            stack.Push("David");
            stack.Push("Emmy");
            stack.Push("Jack");
            stack.Push("Emma");

            //Removing
            Console.WriteLine("Removing " + stack.Pop());
            Console.WriteLine("Removing " + stack.Pop());
            Console.WriteLine("Removing " + stack.Pop());
            Console.WriteLine("Removing " + stack.Pop());

        }
    }
}
