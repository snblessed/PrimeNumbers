using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge.BusinessLayer;
using Ninject;
using System.Threading;

namespace CodeChallenge
{
    public class ProcessFile
    {
        private readonly ICompute primeFactors;
        public string FileName { get; set; }
        public ProcessFile(string fileName, IKernel kernel)
        {
            this.FileName = fileName;
            primeFactors = kernel.Get<Compute>();

        }
        public void Execute()
        {
            #region Validations
            if (FileName.Trim().Length == 0)
            {
                Console.WriteLine("Invalid File Name. Please provide a file name");
                ShowConsoleInDebug();
                return;
            }
            if (!File.Exists(FileName))
            {
                Console.WriteLine(string.Concat(FileName, " - Filename not found. Please provide a valid path"));
                ShowConsoleInDebug();
                return;
            }
            if (Path.GetExtension(FileName).ToLower() != ".txt")
            {
                Console.WriteLine("Only txt files are allowed");
                ShowConsoleInDebug();
                return;

            }
            #endregion

                string[] ls = File.ReadAllLines(FileName);
                //Convert Array to a list of integers
                var lst = Array.ConvertAll<string, int>(ls, int.Parse).ToList();

                //Get a list of key value pairs indicating the prime factors of a number
                primeFactors.FormatOutput(lst);
                
                //Format output
                Console.WriteLine(primeFactors.FormatOutput(lst));
                ShowConsoleInDebug();
        }

        public static void ShowConsoleInDebug()
        {
#if DEBUG
            Console.WriteLine("Press Enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
