using System;
using System.IO;
using AdventOfCodeConsole.Utilities;
using NUnit.Framework;

namespace AdventOfCodeTest.UtilityTests;

public class InputUtilityTests
{
    [Test]
    [TestCase("1\n2", new [] {1, 2})]
    [TestCase("14\n82\n76", new [] {14, 82, 76})]
    [TestCase("14 82 76", new [] {14, 82, 76})]
    public void ConvertStringOfNumbersToIntList(String input, int[] expected)
    {
        Assert.AreEqual(expected, InputUtilities.ConvertInputToIntList(input));
    }

    [Test]
    [TestCase("word word", new [] {"word", "word"})]
    [TestCase("word\nword", new [] {"word", "word"})]
    [TestCase("word\nword word", new [] {"word", "word", "word"})]
    [TestCase("word\n word  word", new [] {"word", "word", "word"})]
    public void ConvertStringOfWordsToStringList(string input, string[] expected)
    {
        Assert.AreEqual(expected, InputUtilities.ConvertInputToStringList(input));
    }

    [Test]
    public void ReadFileToStringThrowsExceptionWhenNoFileIsFound()
    {
        Assert.Throws<FileNotFoundException>(
            () => InputUtilities.ReadFileToString(Path.Combine(TestContext.CurrentContext.TestDirectory, @"TestData\noSuch.txt")));
    }
}