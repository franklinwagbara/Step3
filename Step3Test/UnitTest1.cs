using NUnit.Framework;
using System;

public class LevelCalculatorTests
{
    [TestCase(350, 350)]
    [TestCase(351, 100)]
    [TestCase(352, 101)]
    [TestCase(400, 149)]
    [TestCase(150, 150)]
    [TestCase(1000351, 116)]
    [TestCase(1000352, 117)]
    [TestCase(1000601, 115)]
    public void CalculateActualLevel_ValidInput_ReturnsCorrectLevel(int displayedLevel, int expectedActualLevel)
    {
        Assert.That(LevelCalculator.CalculateActualLevel(displayedLevel), Is.EqualTo(expectedActualLevel));
    }

    [TestCase(-1)]
    [TestCase(-100)]
    public void CalculateActualLevel_NegativeInput_ThrowsArgumentOutOfRangeException(int displayedLevel)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => LevelCalculator.CalculateActualLevel(displayedLevel));
    }

    [Test]
    public void CalculateActualLevel_MaxValueInput_DoesNotOverflow()
    {
        // Test with a large value to ensure no overflow occurs during calculations.
        // The result might not be meaningful in a practical game scenario,
        // but it verifies the robustness of the implementation.
        int displayedLevel = int.MaxValue;
        int cycleLength = 350 - 100 + 1;
        int expectedOffset = (displayedLevel - 350 - 1) % cycleLength;
        int expectedActualLevel = 100 + expectedOffset;

        Assert.That(LevelCalculator.CalculateActualLevel(displayedLevel), Is.EqualTo(expectedActualLevel));
    }
}