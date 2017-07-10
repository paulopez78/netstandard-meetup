using System;
using LoggingLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("Starting app");
            
            Logger.LogInfo("Some info data");

            Logger.LogDebug("Some debug data");

            Console.WriteLine(Logger.Dump());

            Logger.SaveLog("consoleapp-log.xml");
        }
    }
}
