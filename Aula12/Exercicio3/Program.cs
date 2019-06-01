using System;
using System.Collections.Generic;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Our strings
            string[] bunchOfStrings = { "Uma", "Duas", "Tres", "Tres" };

            // Our collections
            List<string> myList = new List<string>();
            Stack<string> myStack = new Stack<string>();
            Queue<string> myQueue = new Queue<string>();
            HashSet<string> mySet = new HashSet<string>();

            // Put all strings in each collection
            foreach (string s in bunchOfStrings)
            {
                myList.Add(s);
                myStack.Push(s);
                myQueue.Enqueue(s);
                mySet.Add(s);
            }

            // Show what's in the list
            Console.WriteLine("Stuff in List:");
            foreach (string s in myList) Console.WriteLine($"\t{s}");

            // Show what's in the stack
            Console.WriteLine("Stuff in Stack:");
            foreach (string s in myStack) Console.WriteLine($"\t{s}");

            // Show what's in the queue
            Console.WriteLine("Stuff in Queue:");
            foreach (string s in myQueue) Console.WriteLine($"\t{s}");

            // Show what's in the set
            Console.WriteLine("Stuff in Set:");
            foreach (string s in mySet) Console.WriteLine($"\t{s}");
        }
    }
}
