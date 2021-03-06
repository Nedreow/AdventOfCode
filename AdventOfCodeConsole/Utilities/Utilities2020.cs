namespace AdventOfCodeConsole.Utilities;

public static class Utilities2020
{
    public static IEnumerable<int> InvertIntList(IEnumerable<int> list, int invertFrom)
    {
        return list.Select(x => invertFrom - x);
    }

    public static int FindCommonValue(IEnumerable<int> array1, IEnumerable<int> array2)
    {
        return array1.Intersect(array2).First();
    }

    public static int[] FindNumberPairTotaling(int[] numbers, int total)
    {
        Array.Sort(numbers);

        int pointerLow = 0;
        int pointerHigh = numbers.Length - 1;

        while (pointerLow != pointerHigh)
        {
            int pairAdded = numbers[pointerLow] + numbers[pointerHigh];

            if (pairAdded == total)
            {
                return new[] { numbers[pointerLow], numbers[pointerHigh] };
            }
            if (pairAdded > total)
            {
                pointerHigh--;
            }
            if (pairAdded < total)
            {
                pointerLow++;
            }
        }

        throw new ArgumentException("No complimenting values in the array");
    }
}