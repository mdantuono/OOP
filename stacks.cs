using System;
using System.Collections;

namespace stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates a new stack
            Stack stack = new Stack();

            // using push, add strings to our stack
            stack.Push("H");
            stack.Push("E");
            stack.Push("Y");

            // print to the console what the stack contains
            Console.WriteLine("The current stack is: ");
            foreach(string s in stack)
            {
                Console.Write(s + " ");
            }

            // print to the console which string can be accessed
            Console.WriteLine("\nThe first available letter in the stack is: ");
            Console.WriteLine(stack.Peek());

            // using pop, remove the available string
            stack.Pop();

            // check once more what the available string is
            Console.WriteLine("After using Pop(), the available letter is: ");
            Console.WriteLine(stack.Peek());
        }
    }

}

// Assignment demonstrating a stack in C#