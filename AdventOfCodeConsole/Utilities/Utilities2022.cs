namespace AdventOfCodeConsole.Utilities;

public class Utilities2022
{
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
}