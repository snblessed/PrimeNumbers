using CodeChallenge.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IKernel kernal = new StandardKernel(new DependencyInject());
                if (args.Length > 0)
                {
                    var pr = new ProcessFile(args[0], kernal);
                    pr.Execute();
                }
                else
                {
                    Console.WriteLine("No argument passed");
                }
            }
            catch (Exception ex)
            {
                //Do something with the exception - Send email/log it in the DB/etc
                //I will just output the message here for now
                Console.WriteLine(ex.Message);
                ProcessFile.ShowConsoleInDebug();
            }
            finally
            {
                //Code that I want to execute regardless
                Console.WriteLine("Code challenge refactoring with Repository Pattern Design " +
                    "with SOLID principles");
            }
        }
    }
}
