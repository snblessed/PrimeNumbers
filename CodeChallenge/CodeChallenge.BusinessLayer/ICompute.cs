using System.Collections.Generic;

namespace CodeChallenge.BusinessLayer
{
    public interface ICompute
    {
        List<KeyValuePair<int, List<int>>> Output { get; set; }

        string FormatOutput(List<int> Numbers);
    }
}