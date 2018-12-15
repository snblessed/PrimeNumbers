using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Repository
{
    public interface IPrimeNumber
    {
        List<int> GetPrimeFactorsOfNumber(int i);
    }
}
