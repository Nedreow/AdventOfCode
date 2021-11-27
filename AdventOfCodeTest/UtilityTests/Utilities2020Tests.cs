using AdventOfCodeConsole.Utilities;
using NUnit.Framework;

namespace AdventOfCodeTest.UtilityTests;

public class Utilities2020Tests
{
    [Test]
    [TestCase(new[] { 16, 7, 12, 36 }, 40, new[] { 24, 33, 28, 4 })]
    public void testInvertIntList(int[] intList, int max, int[] expected)
    {
        int[] invert = Utilities2020.InvertIntList(intList, max);
        
        Assert.AreEqual(expected, invert);
    }
    
    [Test]
    [TestCase(new[] { 16, 7, 20, 12, 36 }, new[] { 24, 20, 33, 28, 4 }, 20)]
    public void testFindCommonValue(int[] list1, int[] list2, int expected)
    {
        int common = Utilities2020.FindCommonValue(list1, list2);
        
        Assert.AreEqual(expected, common);
    }
}