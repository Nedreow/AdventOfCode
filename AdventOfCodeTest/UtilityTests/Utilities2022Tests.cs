using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AdventOfCodeConsole.Utilities;
using NUnit.Framework;

namespace AdventOfCodeTest.UtilityTests;

public class Utilities2022Tests
{
    [Test]
    [TestCase(new[] { 199, 200, 208, 0, 200, 207, 240, 0, 260, 263, 0, 743 }, new[] { 607,  647, 523, 743})]
    public void TestCountCaloriesPerInventory(int[] intArray, int[] expected)
    {
        List<int> countedInventories = Utilities2022.CountCaloriesPerInventory(intArray);
        
        Assert.AreEqual(expected, countedInventories);
    }

    [Test]
    [TestCase(new[] { 199, 200, 208, 0, 200, 207, 240, 0, 260, 263, 0, 743 }, 743)]
    public void TestFindHighestCalorieTotal(int[] intArray, int expected)
    {
        int highestTotal = Utilities2022.FindHighestCalorieTotal(intArray);
        
        Assert.AreEqual(expected, highestTotal);
    }

    [Test]
    [TestCase("A X", 4)]
    [TestCase("A Y", 8)]
    [TestCase("A Z", 3)]
    [TestCase("B X", 1)]
    [TestCase("B Y", 5)]
    [TestCase("B Z", 9)]
    [TestCase("C X", 7)]
    [TestCase("C Y", 2)]
    [TestCase("C Z", 6)]
    [TestCase("ABC", 0)]
    public void TestScoreRPSMatchFaulty(string matchInstruction, int expected)
    {
        int matchScore = Utilities2022.ScoreRPSMatchFaulty(matchInstruction);
        
        Assert.AreEqual(expected, matchScore);
    }

    [Test]
    [TestCase("A X", 3)]
    [TestCase("A Y", 4)]
    [TestCase("A Z", 8)]
    [TestCase("B X", 1)]
    [TestCase("B Y", 5)]
    [TestCase("B Z", 9)]
    [TestCase("C X", 2)]
    [TestCase("C Y", 6)]
    [TestCase("C Z", 7)]
    [TestCase("ABC", 0)]
    public void TestScoreRPSMatchValid(string matchInstruction, int expected)
    {
        int matchScore = Utilities2022.ScoreRPSMatchValid(matchInstruction);
        
        Assert.AreEqual(expected, matchScore);
    }
}