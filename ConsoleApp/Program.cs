using CroweHorwath;
using System;

namespace ConsoleApp
{
    /// <summary>
    /// Console Application for Crowe Horwath
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hello = new HelloWorld();
            Console.WriteLine(hello.SayGreeting());
            Console.ReadLine();
        }
    }
}
