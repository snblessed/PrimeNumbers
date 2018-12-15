using Ninject.Modules;
using CodeChallenge.Repository;
using CodeChallenge.BusinessLayer;
namespace CodeChallenge
{
    public class DependencyInject : NinjectModule
    {
        /// <summary>
        /// Class for dependency injection
        /// </summary>
        public override void Load()
        {
            Bind(typeof(ICompute)).To(typeof(Compute)).InSingletonScope();
            Bind(typeof(IPrimeNumber)).To(typeof(PrimeNumberRepository)).InSingletonScope();
        }
    }
}
