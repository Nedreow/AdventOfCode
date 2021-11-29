using System.IO;

namespace AdventOfCodeConsole.Utilities;

public static class InputUtilities
{ 
    public static string[] ConvertInputToStringList(string input)
    {
        return input.Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries);
    }
    
    public static int[] ConvertInputToIntList(string input)
    {
        return ConvertInputToStringList(input).Select(int.Parse).ToArray();
    }

    public static string ReadFileToString(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException(filePath);
        }
        
        return  File.ReadAllText(filePath);
    }
}