using AdventOfCodeConsole.Utilities._2021;
using NUnit.Framework;

namespace AdventOfCodeTest.UtilityTests._2021;

public class SubmarineTests
{
    [Test]
    [TestCase(0, 0, new[] { 0, 0 })]
    [TestCase(4, 7, new[] { 4, 7 })]
    public void TestGetSubLocation(int distance, int depth, int[] expected)
    {
        SimpleSubmarine sub = new SimpleSubmarine(distance, depth);

        Assert.AreEqual(expected[0], sub.Distance);
        Assert.AreEqual(expected[1], sub.Depth);
    }

    [Test]
    [TestCase(new[] { 0, 0 }, new[] { "forward 5", "down 5", "forward 8", "up 3", "down 8", "forward 2" }, new[] { 15, 10 })]
    public void TestSubmarineMovement(int[] initialLocation, string[] movementCommands, int[] expectedLocation)
    {
        SimpleSubmarine sub = new SimpleSubmarine(initialLocation[0], initialLocation[1]);

        sub.Move(movementCommands);
        
        Assert.AreEqual(expectedLocation[0], sub.Distance);
        Assert.AreEqual(expectedLocation[1], sub.Depth);
    }

    [Test]
    [TestCase(new[] { 0, 0, 0 }, new[] { "forward 5", "down 5", "forward 8", "up 3", "down 8", "forward 2" }, new[] { 15, 60 })]
    public void TestAimedSubmarineMovement(int[] initialLocation, string[] movementCommands, int[] expectedLocation)
    {
        AimedSubmarine sub = new AimedSubmarine(initialLocation[0], initialLocation[1], initialLocation[2]);
        
        sub.Move(movementCommands);
        
        Assert.AreEqual(expectedLocation[0], sub.Distance);
        Assert.AreEqual(expectedLocation[1], sub.Depth);
    }
}