using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Repository
{
    /// <summary>
    /// Prime Number class definition.
    /// Repository Pattern
    /// </summary>
    public class PrimeNumberRepository : IPrimeNumber
    {
        public List<int> GetPrimeFactorsOfNumber(int i)
        {
            List<int> factors = new List<int>();
            for (int b = 2; i > 1; b++)
            {
                if (i % b == 0)
                {
                    while (i % b == 0)
                    {
                        i /= b;
                        factors.Add(b);
                    }
                }
            }
            return factors;
        }
    }
}