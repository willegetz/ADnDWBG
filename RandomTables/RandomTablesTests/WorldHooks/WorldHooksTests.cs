﻿using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RandomTables.WorldHooks;

namespace RandomTablesTests.WorldHooks
{
    [TestClass]
    public class WorldHooksTests
    {
        [TestMethod]
        public void GetClimateOrLandformMountain()
        {
            // In order to get the correct type I need to mock the characteristic seedGenerator
            // In order to get the correct subtype I need to mock the subtype seedGenerator
        }

        [TestMethod]
        public void FixTheClimateOrLandformFactory()
        {
            // The factory chosen from the lookup returns an instance of ClimateOrLandform, not
            // a factory.

            var mockCharacteristicSeedGenerator = new Mock<ISeedGenerator>();
            mockCharacteristicSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                                           .Returns(14)  // Tens result first
                                           .Returns(18); // Tens result second

            // Mock out the die instead of the random seed?
            var mockSubtypeSeedGenerator = new Mock<ISeedGenerator>();
            mockSubtypeSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                                    .Returns(1)  // D8 result first
                                    .Returns(0); // D6 result second

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.GetWorldHookFactory();

            var worldHook = hookFactory.GetWorldHook(mockSubtypeSeedGenerator.Object);
            var hook = worldHook.GetHook();

            Assert.AreEqual("", hook);
        }
    }
}
