using NUnit.Framework;

namespace VannOppgave.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test01WaterAt20Degrees()
        {
            var water = new Water(50, 20);
            Assert.AreEqual(WaterState.Fluid, water.State);
            Assert.AreEqual(20, water.Temperature);
            Assert.AreEqual(50, water.Amount);
        }

        [Test]
        public void Test02WaterAtMinus20Degrees()
        {
            var water = new Water(50, -20);
            Assert.AreEqual(WaterState.Ice, water.State);
            Assert.AreEqual(-20, water.Temperature);
        }
        [Test]
        // Tester om tilstanden blir gass ved 120 grader
        public void Test03WaterAt120Degrees()
        {
            var water = new Water(50, 120);
            Assert.AreEqual(WaterState.Gas, water.State);
            Assert.AreEqual(120, water.Temperature);
        }
        [Test]
        // Ved 0 og 100 grader må vi angi en frivillig parameter til constructoren som angir hvor stor del 
        // som er i den første fasen (altså is ved blanding av is og flytende - og flytende ved blanding 
        // av flytende og gass). Denne testen sjekker at vi får exception om dette ikke er angitt og temperaturen
        // er 100 grader. 
        [ExpectedException(typeof(ArgumentException),
            "When temperature is 0 or 100, you must provide a value for proportion")]
        public void Test04WaterAt100DegreesWithoutProportion()
        {
            var water = new Water(50, 100);
        }

    }
}