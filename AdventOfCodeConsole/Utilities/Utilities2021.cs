namespace AdventOfCodeConsole.Utilities;

public static class Utilities2021
{
    public static int CountIncreased(IEnumerable<int> values)
    {
        List<int> valuesList = values.ToList();
        
        int increasedCount = 0;
        for (int j = 1; j < valuesList.Count(); j++)
        {
            if (valuesList.ElementAt(j) > valuesList.ElementAt(j-1))
            {
                increasedCount++;
            }
        }
        
        return increasedCount;
    }

    public static List<int> SumSlices(IEnumerable<int> values, int sliceSize)
    {
        List<int> valuesList = values.ToList();
        
        var summedSlices = new List<int>();
        for (int i = 0; i < valuesList.Count() - (sliceSize - 1); i++)
        {
            summedSlices.Add(valuesList.GetRange(i, sliceSize).Sum());
        }
        
        return summedSlices;
    }
}