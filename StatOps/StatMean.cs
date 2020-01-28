using System;
using Helpers;
using Operations;

namespace StatOps
{
    public class StatMean
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = Addition.Add(values);
            var valueCount = Arrays.Length(values);
            var mean = Division.Divide(sum, valueCount);
            return mean;
        }
    }
}
