namespace AdventOfCodeConsole.Tasks;

public abstract class Advent
{
    private readonly SolutionList _solutionList;
    public SolutionList SolutionList => _solutionList;

    protected Advent(string year)
    {
        _solutionList = new SolutionList(year);
    }

    public void SolveTasks()
    {
        _solutionList.AddSolution("1_1", SolveTask1_1());
        _solutionList.AddSolution("1_2", SolveTask1_2());
        _solutionList.AddSolution("2_1", SolveTask2_1());
        _solutionList.AddSolution("2_2", SolveTask2_2());
        _solutionList.AddSolution("3_1", SolveTask3_1());
        _solutionList.AddSolution("3_2", SolveTask3_2());
        _solutionList.AddSolution("4_1", SolveTask4_1());
        _solutionList.AddSolution("4_2", SolveTask4_2());
        _solutionList.AddSolution("5_1", SolveTask5_1());
        _solutionList.AddSolution("5_2", SolveTask5_2());
        _solutionList.AddSolution("6_1", SolveTask6_1());
        _solutionList.AddSolution("6_2", SolveTask6_2());
        _solutionList.AddSolution("7_1", SolveTask7_1());
        _solutionList.AddSolution("7_2", SolveTask7_2());
        _solutionList.AddSolution("8_1", SolveTask8_1());
        _solutionList.AddSolution("8_2", SolveTask8_2());
        _solutionList.AddSolution("9_1", SolveTask9_1());
        _solutionList.AddSolution("9_2", SolveTask9_2());
        _solutionList.AddSolution("10_1", SolveTask10_1());
        _solutionList.AddSolution("10_2", SolveTask10_2());
        _solutionList.AddSolution("11_1", SolveTask11_1());
        _solutionList.AddSolution("11_2", SolveTask11_2());
        _solutionList.AddSolution("12_1", SolveTask12_1());
        _solutionList.AddSolution("12_2", SolveTask12_2());
        _solutionList.AddSolution("13_1", SolveTask13_1());
        _solutionList.AddSolution("13_2", SolveTask13_2());
        _solutionList.AddSolution("14_1", SolveTask14_1());
        _solutionList.AddSolution("14_2", SolveTask14_2());
        _solutionList.AddSolution("15_1", SolveTask15_1());
        _solutionList.AddSolution("15_2", SolveTask15_2());
        _solutionList.AddSolution("16_1", SolveTask16_1());
        _solutionList.AddSolution("16_2", SolveTask16_2());
        _solutionList.AddSolution("17_1", SolveTask17_1());
        _solutionList.AddSolution("17_2", SolveTask17_2());
        _solutionList.AddSolution("18_1", SolveTask18_1());
        _solutionList.AddSolution("18_2", SolveTask18_2());
        _solutionList.AddSolution("19_1", SolveTask19_1());
        _solutionList.AddSolution("19_2", SolveTask19_2());
        _solutionList.AddSolution("20_1", SolveTask20_1());
        _solutionList.AddSolution("20_2", SolveTask20_2());
        _solutionList.AddSolution("20_1", SolveTask21_1());
        _solutionList.AddSolution("20_2", SolveTask21_2());
        _solutionList.AddSolution("20_1", SolveTask22_1());
        _solutionList.AddSolution("20_2", SolveTask22_2());
        _solutionList.AddSolution("20_1", SolveTask23_1());
        _solutionList.AddSolution("20_2", SolveTask23_2());
        _solutionList.AddSolution("20_1", SolveTask24_1());
        _solutionList.AddSolution("20_2", SolveTask24_2());
        _solutionList.AddSolution("20_1", SolveTask25_1());
        _solutionList.AddSolution("20_2", SolveTask25_2());
    }
    
    public virtual string? SolveTask1_1()
    {
        return null;
    }
    
    public virtual string? SolveTask1_2()
    {
        return null;
    }
    
    public virtual string? SolveTask2_1()
    {
        return null;
    }
    
    public virtual string? SolveTask2_2()
    {
        return null;
    }
    
    public virtual string? SolveTask3_1()
    {
        return null;
    }
    
    public virtual string? SolveTask3_2()
    {
        return null;
    }
    
    public virtual string? SolveTask4_1()
    {
        return null;
    }
    
    public virtual string? SolveTask4_2()
    {
        return null;
    }
    
    public virtual string? SolveTask5_1()
    {
        return null;
    }
    
    public virtual string? SolveTask5_2()
    {
        return null;
    }
    
    public virtual string? SolveTask6_1()
    {
        return null;
    }
    
    public virtual string? SolveTask6_2()
    {
        return null;
    }
    
    public virtual string? SolveTask7_1()
    {
        return null;
    }
    
    public virtual string? SolveTask7_2()
    {
        return null;
    }
    
    public virtual string? SolveTask8_1()
    {
        return null;
    }
    
    public virtual string? SolveTask8_2()
    {
        return null;
    }
    
    public virtual string? SolveTask9_1()
    {
        return null;
    }
    
    public virtual string? SolveTask9_2()
    {
        return null;
    }
    
    public virtual string? SolveTask10_1()
    {
        return null;
    }
    
    public virtual string? SolveTask10_2()
    {
        return null;
    }
    
    public virtual string? SolveTask11_1()
    {
        return null;
    }
    
    public virtual string? SolveTask11_2()
    {
        return null;
    }
    
    public virtual string? SolveTask12_1()
    {
        return null;
    }
    
    public virtual string? SolveTask12_2()
    {
        return null;
    }
    
    public virtual string? SolveTask13_1()
    {
        return null;
    }
    
    public virtual string? SolveTask13_2()
    {
        return null;
    }
    
    public virtual string? SolveTask14_1()
    {
        return null;
    }
    
    public virtual string? SolveTask14_2()
    {
        return null;
    }
    
    public virtual string? SolveTask15_1()
    {
        return null;
    }
    
    public virtual string? SolveTask15_2()
    {
        return null;
    }
    
    public virtual string? SolveTask16_1()
    {
        return null;
    }
    
    public virtual string? SolveTask16_2()
    {
        return null;
    }
    
    public virtual string? SolveTask17_1()
    {
        return null;
    }
    
    public virtual string? SolveTask17_2()
    {
        return null;
    }
    
    public virtual string? SolveTask18_1()
    {
        return null;
    }
    
    public virtual string? SolveTask18_2()
    {
        return null;
    }
    
    public virtual string? SolveTask19_1()
    {
        return null;
    }
    
    public virtual string? SolveTask19_2()
    {
        return null;
    }
    
    public virtual string? SolveTask20_1()
    {
        return null;
    }
    
    public virtual string? SolveTask20_2()
    {
        return null;
    }
    
    public virtual string? SolveTask21_1()
    {
        return null;
    }
    
    public virtual string? SolveTask21_2()
    {
        return null;
    }
    
    public virtual string? SolveTask22_1()
    {
        return null;
    }
    
    public virtual string? SolveTask22_2()
    {
        return null;
    }
    
    public virtual string? SolveTask23_1()
    {
        return null;
    }
    
    public virtual string? SolveTask23_2()
    {
        return null;
    }
    
    public virtual string? SolveTask24_1()
    {
        return null;
    }
    
    public virtual string? SolveTask24_2()
    {
        return null;
    }
    
    public virtual string? SolveTask25_1()
    {
        return null;
    }
    
    public virtual string? SolveTask25_2()
    {
        return null;
    }
}