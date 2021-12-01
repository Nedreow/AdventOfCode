using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCodeConsole.Utilities;
using NUnit.Framework;

namespace AdventOfCodeTest.UtilityTests;

public class Utilities2021Tests
{
    [Test]
    [TestCase(new[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 }, 7)]
    public void TestCountIncreased(int[] intArray, int expected)
    {
        int count = Utilities2021.CountIncreased(intArray);
        
        Assert.AreEqual(expected, count);
    }

    [Test]
    [TestCase(
        new [] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 }, 
        3, 
        new[] { 607, 618, 618, 617, 647, 716, 769, 792 }
        )]
    [TestCase(
        new[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 }, 
        2, 
        new[] { 399, 408, 418, 410, 407, 447, 509, 529, 523 }
        )]
    public void TestSumSlices(int[] intArray, int sliceSize, int[] expected)
    {
        List<int> summedSlices = Utilities2021.SumSlices(intArray, sliceSize);
        
        Assert.AreEqual(expected, summedSlices);
    }
}