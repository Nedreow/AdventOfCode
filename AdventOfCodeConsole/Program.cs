using AdventOfCodeConsole.Tasks;

namespace AdventOfCodeConsole // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Advent2022 tasks = new Advent2022();
            
            tasks.SolveTasks();

            foreach (var solution in tasks.SolutionList.Solutions)
            {
                if (solution.Value != null)
                {
                    Console.WriteLine($"The Solution to task {solution.Key} is: {solution.Value}");
                }
            }
            
            Console.WriteLine("");
            Console.WriteLine("A total of " + tasks.SolutionList.SolvedCount + "/40 tasks have been completed");
        }
    }
}