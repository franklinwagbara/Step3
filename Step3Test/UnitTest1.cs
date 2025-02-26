using NUnit.Framework;
using System;

public class GameLevelTests
{
    [TestFixture]
    public class CalculateActualLevelTests
    {
        [Test]
        public void CalculateActualLevel_DisplayedLevelIs350_Returns350()
        {
            Assert.That(GameLevel.CalculateActualLevel(350), Is.EqualTo(350));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs351_Returns100()
        {
            Assert.That(GameLevel.CalculateActualLevel(351), Is.EqualTo(100));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs352_Returns101()
        {
            Assert.That(GameLevel.CalculateActualLevel(352), Is.EqualTo(101));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs400_Returns149()
        {
            Assert.That(GameLevel.CalculateActualLevel(400), Is.EqualTo(149));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs150_Returns150()
        {
            Assert.That(GameLevel.CalculateActualLevel(150), Is.EqualTo(150));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs1000351_Returns116()
        {
            Assert.That(GameLevel.CalculateActualLevel(1000351), Is.EqualTo(116));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs1000352_Returns117()
        {
            Assert.That(GameLevel.CalculateActualLevel(1000352), Is.EqualTo(117));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs1000601_Returns115()
        {
            Assert.That(GameLevel.CalculateActualLevel(1000601), Is.EqualTo(115));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIsZero_ReturnsZero()
        {
            Assert.That(GameLevel.CalculateActualLevel(0), Is.EqualTo(0));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs1_Returns1()
        {
            Assert.That(GameLevel.CalculateActualLevel(1), Is.EqualTo(1));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIsIntMaxValue_ReturnsCorrectValue()
        {
            // The expected value is calculated as follows:
            // 1. offset = (int.MaxValue - 351) % 251
            // 2. result = 100 + offset

            long displayedLevel = int.MaxValue;
            long offset = (displayedLevel - 351) % 251;
            long expected = 100 + offset;

            Assert.That(GameLevel.CalculateActualLevel(int.MaxValue), Is.EqualTo((int)expected));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs349_Returns349()
        {
            Assert.That(GameLevel.CalculateActualLevel(349), Is.EqualTo(349));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIsNegative_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => GameLevel.CalculateActualLevel(-1));
        }
    }
}