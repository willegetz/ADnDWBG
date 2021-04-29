using System;
using System.Linq;

namespace RandomTables.TestHelpers
{
    public class SeedFinder
    {
        public int GetSeed(int inclusiveLowerBound, int exclusiveUpperBound, int desiredResult)
        {
            var seed = Enumerable.Range(0, 100).Where(x =>
            {
                var rando = new Random(x);
                var randRes = rando.Next(inclusiveLowerBound, exclusiveUpperBound);

                return randRes == desiredResult;
            }).FirstOrDefault();

            return seed;
        }
    }
}
