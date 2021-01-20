using System;
using System.Diagnostics;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            //string windir = Environment.GetEnvironmentVariable("windir");

            if (string.IsNullOrEmpty(windir.Trim()))
            {
                windir = "C:\\Windows\\";
            }
            if (!windir.EndsWith("\\"))
            {
                windir += "\\";
            }
            */


            Process.Start("explorer.exe");
        }

    }
}
