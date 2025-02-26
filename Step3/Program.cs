public class GameLevel
{
    /// <summary>
    /// Calculates the actual level configuration for a given displayed level.
    /// After level 350, the game cycles through levels 100 to 350 while keeping
    /// the displayed level increasing.
    /// </summary>
    /// <param name="displayedLevel">The level displayed to the player.</param>
    /// <returns>The corresponding actual level configuration.</returns>
    public static int CalculateActualLevel(int displayedLevel)
    {
        if (displayedLevel < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(displayedLevel), "Displayed level cannot be negative.");
        }

        if (displayedLevel <= 350)
        {
            return displayedLevel;
        }

        int offset = (displayedLevel - 351) % 251;
        return 100 + offset;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(CalculateActualLevel(100));
    }
}