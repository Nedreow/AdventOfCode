namespace AdventOfCodeConsole.Utilities;

public static class InputUtilities
{ 
    public static IEnumerable<string> ConvertInputToStringList(string input, bool omitEmpty = true)
    {
        if (omitEmpty)
        {
            return input.Split('\n', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim());
        }
        return input.Split('\n').Select(s => s.Trim());
    }
    
    public static IEnumerable<int> ConvertInputToIntList(string input, bool omitEmpty = true)
    {
        return ConvertInputToStringList(input, omitEmpty)
            .Select(inputPiece => string.IsNullOrEmpty(inputPiece) ? 0 : int.Parse(inputPiece))
            .ToArray();
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