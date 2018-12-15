using CodeChallenge.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.BusinessLayer
{
    /// <summary>
    /// Business Layer classes that acts as a bridge between the repository classes
    /// and the UI. Sometimes is would be the service layer.In this class I'm using Dependency
    /// Injection and only access the repository interface.
    /// </summary>
    public class Compute : ICompute
    {
        private IPrimeNumber repository;
        public List<KeyValuePair<int, List<int>>> Output { get; set; }

        /// <summary>
        /// Constructor that injects the PrimeNumber repository
        /// </summary>
        /// <param name="_repository"></param>
        public Compute(IPrimeNumber _repository)
        {
            this.repository = _repository;
        }
        /// <summary>
        /// Returns the StringOutput
        /// </summary>
        /// <param name="Numbers"></param>
        /// <returns></returns>
        public string FormatOutput(List<int> Numbers)
        {
            Output = new List<KeyValuePair<int, List<int>>>();
            StringBuilder Result= new StringBuilder();

            //Go through each number in the file, and return the prime factorys
            foreach (int i in Numbers)
            {
                var lst = repository.GetPrimeFactorsOfNumber(i);
                Output.Add(new KeyValuePair<int, List<int>>(i,lst));
            }
            foreach (KeyValuePair<int,List<int>> kvp in Output)
            {
                Result.AppendLine(string.Concat(kvp.Key, ": ", (kvp.Value.Count > 0) ? string.Join(", ", (kvp.Value)):"No prime number exists"));
            }
            return Result.ToString();
    }
    }
}
