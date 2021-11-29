using System.Collections;

namespace AdventOfCodeConsole.Tasks;

public class SolutionList
{
    private string _year; 
    public string Year => _year;

    private Dictionary<string, string?> _solutions;
    public Dictionary<string, string?> Solutions => _solutions;
    
    public string SolvedCount
    {
        get => _solvedCount();
    }

    public SolutionList(string year)
    {
        _year = year;
        _solutions = new Dictionary<string, string?>();
    }

    public void AddSolution(string task, string? answer)
    {
        _solutions.Add(task, answer);
    }

    private string _solvedCount()
    {
        int solvedCount = _solutions.Values.Aggregate(0, (solved, next) => 
            next != null ? solved + 1 : solved);

        return solvedCount.ToString();
    }
}