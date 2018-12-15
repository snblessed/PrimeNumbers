using CodeChallenge.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Tests
{
    [TestFixture]
    public class PrimeNumberRepositoryTest
    {
        [Test]
        //Test case #1 - Verify that we can't get prime number for 1
        public void Is1APrimeNumber()
        {
            var repo = new PrimeNumberRepository();
            Assert.True(repo.GetPrimeFactorsOfNumber(1).Count==0);

        }
        [Test]
        //Test case #2 verify that returned list of prime factors is not empty
        public void HasPrimeFactors()
        {
            var repo = new PrimeNumberRepository();
            Assert.True(repo.GetPrimeFactorsOfNumber(178).Count>0);
        }
    }
}
