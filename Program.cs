//Author:Liam Kelly
//Date: 9/24/2020
//Description: Tech Project 3a. Methods

using System;

namespace techproject3a
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your first and last name");
            string input = Console.ReadLine();
            
            printName(input);
        } 
              
        private static void printName(string name)
        {
            
            if (name == "Liam Kelly")
                Console.WriteLine("Hello " + name + " - Go Bolts!");            
            else
                Console.WriteLine("Hello " + name + " - Have a great day");

        }
    }
}
