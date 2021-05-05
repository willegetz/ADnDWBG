using DiceTypes.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomTables.TestHelpers
{
    public class SeedHelper
    {
        public static int FindSeed(int inclusiveLowerBound, int exclusiveUpperBound, int desiredResult)
        {
            var seed = Enumerable.Range(0, 100).Where(x =>
            {
                var rando = new Random(x);
                var randRes = rando.Next(inclusiveLowerBound, exclusiveUpperBound);

                return randRes == desiredResult;
            }).FirstOrDefault();

            return seed;
        }

        public static Mock<ISeedGenerator> GetMockSeedGenerator(int[] seeds)
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed())
                             .Returns(new Queue<int>(seeds).Dequeue);

            return mockSeedGenerator;
        }
    }
}
