using System;
using System.IO;
using AdventOfCodeConsole.Utilities;
using NUnit.Framework;

namespace AdventOfCodeTest.UtilityTests;

public class InputUtilityTests
{
    [Test]
    [TestCase("1\n2", true, new [] {1, 2})]
    [TestCase("14\n82\n76", true, new [] {14, 82, 76})]
    [TestCase("14\n\n82\n76", false, new [] {14, 0, 82, 76})]
    public void ConvertStringOfNumbersToIntList(String input, bool omitEmpty, int[] expected)
    {
        var convertedInput = InputUtilities.ConvertInputToIntList(input, omitEmpty);
        Assert.AreEqual(expected, convertedInput);
    }

    [Test]
    [TestCase("wordword", new [] {"wordword"})]
    [TestCase("word\nword", new [] {"word", "word"})]
    [TestCase("word\nword word", new [] {"word", "word word"})]
    [TestCase("word\n word\n\nword", new [] {"word", "word", "word"})]
    public void ConvertStringOfWordsToStringList(string input, string[] expected)
    {
        Assert.AreEqual(expected, InputUtilities.ConvertInputToStringList(input));
    }

    [Test]
    public void GetInputThrowsExceptionWhenNoFileIsFound()
    {
        Assert.Throws<FileNotFoundException>(
            () => InputUtilities.GetInput("2000", "3_4"));
    }
}