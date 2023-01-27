using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvsView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int nn = 0;
            if (args.Count()>0)
            {
                Console.WriteLine(args[0]);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                try
                {
                    string[] lines = System.IO.File.ReadAllLines("" + args[0]);

                    for (n = 0; n < lines.Count(); n++)
                    {
                        string[] fields = lines[n].Split(',');

                        for (nn = 0; nn < fields.Count(); nn++)
                        {
                            Console.Write(fields[nn] + "\t\t");
                        }
                        Console.Write("\r\n");
                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine("\n" + Directory.GetCurrentDirectory() + ",file error:");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n" + Directory.GetCurrentDirectory() + ",file error:");
            }
        }
    }
}
