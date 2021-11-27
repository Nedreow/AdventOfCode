namespace AdventOfCodeConsole.Utilities;

public class Utilities2020
{
    public static int[] InvertIntList(int[] list, int invertFrom)
    {
        return list.Select(x => invertFrom - x).ToArray();
    }

    public static int FindCommonValue(int[] array1, int[] array2)
    {
        return array1.Intersect(array2).First();
    }
}