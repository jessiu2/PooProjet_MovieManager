using System;
using System.Collections.Generic;

namespace MovieManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie Manager!");
            Console.WriteLine("Type 'help' to see available commands.");
            
            Command mycommand = new MyCommand();
            mycommand.Execute();
        }
    }
}