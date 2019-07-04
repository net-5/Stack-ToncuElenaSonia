using System;
using System.Collections.Generic;

namespace StackProject
{
    class Program
    {
        //Ajungeti la ultimul element fara sa modificati elementele din stack.
        static void Main(string[] args)
        {
            ReturnLastElementFromStack();       
        }
        public static void ReturnLastElementFromStack()
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Monday");
            myStack.Push("Tuesday");
            myStack.Push("Wednesday");
            myStack.Push("Thursday");
            myStack.Push("Friday");
            myStack.Push("Saturday");
            myStack.Push("Sunday");
            string[] myArray = myStack.ToArray();
            foreach (string item in myArray)
            {
                Console.WriteLine(item);
                if (item == myArray[myArray.Length - 1])
                {
                    Console.WriteLine($"The last element from the stack is {item}");
                }
            }
        }
    }
}
