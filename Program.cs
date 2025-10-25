using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("What is your age? ");
            string age = Console.ReadLine();

            Console.WriteLine($"\nHello {name}! You are {age} years old.");
        }
    }
}
