using System;
using LoggingLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("Starting app");

            Console.WriteLine("Running my Awesome Console App");

            Logger.Log("Finishing app");
        }
    }
}
