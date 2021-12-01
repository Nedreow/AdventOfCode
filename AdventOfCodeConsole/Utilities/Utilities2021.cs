namespace AdventOfCodeConsole.Utilities;

public static class Utilities2021
{
    public static int CountIncreased(int[] values)
    {
        int increasedCount = 0;
        for (int j = 1; j < values.Length; j++)
        {
            if (values[j] > values[j-1])
            {
                increasedCount++;
            }
        }
        
        return increasedCount;
    }

    public static int[] sumSlices(int[] values, int sliceSize)
    {
        var summedSlices = new List<int>();
        for (int i = 0; i < values.Length - (sliceSize - 1); i++)
        {
            summedSlices.Add(values[i..(i+sliceSize)].Sum());
        }
        
        return summedSlices.ToArray();
    }
}