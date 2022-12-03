namespace AdventOfCodeConsole.Utilities;

public class Utilities2022
{
    private static readonly Dictionary<string, int> ValidRPSMatchesV1 = new Dictionary<string, int>()
    {
        { "A X", 4 },
        { "A Y", 8 },
        { "A Z", 3 },
        { "B X", 1 },
        { "B Y", 5 },
        { "B Z", 9 },
        { "C X", 7 },
        { "C Y", 2 },
        { "C Z", 6 },
    };
    
    private static readonly Dictionary<string, int> ValidRpsMatchesV2 = new Dictionary<string, int>()
    {
        { "A X", 3 },
        { "A Y", 4 },
        { "A Z", 8 },
        { "B X", 1 },
        { "B Y", 5 },
        { "B Z", 9 },
        { "C X", 2 },
        { "C Y", 6 },
        { "C Z", 7 },
    };

    public static int FindHighestCalorieTotal(IEnumerable<int> candyInventories)
    {
        return CountCaloriesPerInventory(candyInventories).Max();
    }

    public static List<int> CountCaloriesPerInventory(IEnumerable<int> candyInventories)
    {
        List<int> calorieTotals = new List<int>(){0};
        
        foreach (var candyCalories in candyInventories)
        {
            calorieTotals[^1] += candyCalories;

            if (candyCalories == 0)
            {
                calorieTotals.Add(0);
            }
        }

        return calorieTotals;
    }

    public static int ScoreRPSMatchFaulty(string matchInstruction)
    {
        return ValidRPSMatchesV1.ContainsKey(matchInstruction) ? ValidRPSMatchesV1[matchInstruction] : 0;
    }

    public static int ScoreRPSMatchValid(string matchInstruction)
    {
        return ValidRpsMatchesV2.ContainsKey(matchInstruction) ? ValidRpsMatchesV2[matchInstruction] : 0;
    }
}