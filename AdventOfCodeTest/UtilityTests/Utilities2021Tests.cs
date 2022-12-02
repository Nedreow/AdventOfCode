using System;
using System.Collections;
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

    [Test]
    [TestCase("011111100101", '0', 4)]
    [TestCase("011111100101", '1', 8)]
    [TestCase("Hello World", 'W', 1)]
    [TestCase("Hello World", 'o', 2)]
    public void TestCharCount(string sentence, char toCount, int expected)
    {
        int count = Utilities2021.CountChar(sentence, toCount);
        
        Assert.AreEqual(expected, count);
    }

    [Test]
    [TestCase(new [] {false, true}, 2)]
    [TestCase(new [] {false, false}, 0)]
    [TestCase(new [] {true, false, false, false}, 1)]
    [TestCase(new [] {false, true, false, true}, 10)]
    public void TestBitArrayToIntConversion(bool[] input, int expected)
    {
        BitArray bits = new BitArray(input);

        int value = bits.ToNumeral();
        
        Assert.AreEqual(expected, value);
    }

    [Test]
    [TestCase(new [] { "t", "e", "s", "t" }, new [] { "test" })]
    public void TestStringListRowToColumn(IEnumerable<string> strings, IEnumerable<string> expected)
    {
        List<string> result = Utilities2021.StringListRowToColumn(strings);
        
        Assert.AreEqual(expected, result);
    }
}