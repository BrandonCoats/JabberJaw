using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLinkage
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\dev\\Python\\python2\\python.exe";
            //start.FileName = "C:\\dev\\Capstone\\JabberJaw(Working Tiitle)\\JabberJaw\\Python\\Chunking.py";
            //Console.Write(args.Length);
            // arg[0] = Path to your python script (example : "C:\\add_them.py")
            // arg[1] = first arguement taken from  C#'s main method's args variable (here i'm passing a number : 5)
            // arg[2] = second arguement taken from  C#'s main method's args variable ( here i'm passing a number : 6)
            // pass these to your Arguements property of your ProcessStartInfo instance

            start.Arguments = string.Format("{0} {1} {2}", "C:\\dev\\Capstone\\JabberJaw\\JabberJaw\\Python\\Chunking.py", 5,6);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    // this prints 11
                    Console.Write(result);

                }
            }
            Console.Read();
        }
    }
}
