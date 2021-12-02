namespace AdventOfCodeConsole.Utilities;

public static class InputUtilities
{ 
    public static IEnumerable<string> ConvertInputToStringList(string input)
    {
        return input.Split('\n', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim());
    }
    
    public static IEnumerable<int> ConvertInputToIntList(string input)
    {
        return ConvertInputToStringList(input).Select(int.Parse).ToArray();
    }

    public static string GetInput(string year, string task)
    {
        string filePath = Path.GetFullPath($@"..\..\..\Tasks\Input\{year}\{task}.txt");
        
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException(filePath);
        }
        return File.ReadAllText(filePath);
    }
}