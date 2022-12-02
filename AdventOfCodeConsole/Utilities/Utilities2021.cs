using System.Collections;

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

    public static int CountChar(string sentence, char toCount)
    {
        return sentence.ToList().FindAll(c => c == toCount).Count;
    }
    
    public static int ToNumeral(this BitArray binary)
    {
        if (binary == null)
            throw new ArgumentNullException("binary");
        if (binary.Length > 32)
            throw new ArgumentException("must be at most 32 bits long");

        var result = new int[1];
        binary.CopyTo(result, 0);
        return result[0];
    }

    public static List<string> StringListRowToColumn(IEnumerable<string> strings)
    {
        List<string> stringList = strings.ToList();
        List<string> columned = new List<string>();

        char a = stringList[0][0];

        for (int i = 0; i < stringList[0].Length; i++)
        {
            columned.Add("");

            for (int j = 0; j < stringList.Count; j++)
            {
                columned[i] += stringList[j][i];
            }
        }

        return columned;
    }
}