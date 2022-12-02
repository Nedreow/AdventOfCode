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
}