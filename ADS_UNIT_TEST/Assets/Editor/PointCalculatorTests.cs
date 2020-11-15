using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using System;

public class PointCalculatorTests
{
    #region Calculate Points
    [Test]
    [TestCase(3, 0, 1, 300)]
    [TestCase(5, 0, 1, 500)]
    [TestCase(5, 0, 2, 1000)]
    [TestCase(5, 1, 2, 800)]
    [TestCase(10, 0, 1, 1000 + 500)]
    [TestCase(21, 0, 2, 6200)]
    [TestCase(11, 3, 1, 1300)]
    [TestCase(10, 10, 5, 500)]
    [TestCase(0, 0, 1, 0)]
    [TestCase(0, 4, 1, 0)]

    public void CalculatePoints_Test(int killedEnemies, int killedVillagers, int multiplicator, int expectedPoints)
    {
        PointCalculator pointCalculator = new PointCalculator();

        int points = pointCalculator.CalculatePoints(killedEnemies, killedVillagers, multiplicator);

        Assert.That(points, Is.EqualTo(expectedPoints));
    }
    #endregion


    [Test]
    public void CalculatePoints_NegativeKilledEnemies_ThrowsExceptions()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new PointCalculator().CalculatePoints(-1, 0, 1));
    }

    [Test]
    public void CalculatePoints_NegativeKilledVillagers_ThrowsExceptions([Values(-2,-1)] int killedVillagers)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new PointCalculator().CalculatePoints(0, killedVillagers, 1));
    }

    [Test]
    public void CalculatePoints_NegativeOrZeroMultiplicator_ThrowsExceptions([Values(0, -1)]int multiplicator)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new PointCalculator().CalculatePoints(0, -1, multiplicator));
    }
}
