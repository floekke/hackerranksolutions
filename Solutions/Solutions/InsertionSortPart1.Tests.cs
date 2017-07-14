﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

[TestFixture]
class InsertionSortPart1Tests
{

    [Test]
    public void FooTest()
    {
        var result = InsertionSortPart1.insertionSort(new[] { 1, 2, 0 });
        AssertEqual(new[] { 0, 1, 2 }, result);
            
    }

    void AssertEqual(int[] x, int[] y)
    {
        for (int i = 0; i < x.Length; i++)
        {
            Assert.AreEqual(x[i], y[i]);
        }
    }
}