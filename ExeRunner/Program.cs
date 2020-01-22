using System;
using System.Diagnostics;

namespace ExeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Path: ");
            string filePath = Console.ReadLine();
            
            Process proc = new Process();
			
            proc.StartInfo.FileName = filePath;
            proc.StartInfo.Arguments = "-v -s -a";
            proc.Start();
            proc.WaitForExit();
            int exitCode = proc.ExitCode;
			
            proc.Close();

            Console.ReadLine();
        }
    }
}
