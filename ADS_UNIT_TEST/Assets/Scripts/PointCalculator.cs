using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PointCalculator
{
    public int CalculatePoints(int killedEnemies, int killedVillagers, int multiplicator)
    {
        if (killedEnemies < 0)
        {
            throw new ArgumentOutOfRangeException("Killed enemies must be positive");
        }

        if (killedVillagers < 0)
        {
            throw new ArgumentOutOfRangeException("Killed villagers must be positive");
        }

        if (multiplicator < 0)
        {
            throw new ArgumentOutOfRangeException("Multiplicator must be greater than zero");
        }

        int points = 0;

        points += killedEnemies * 100;
        points +=  Mathf.FloorToInt(killedEnemies / 10) * 500;
        points -= killedVillagers * 100;

        if (killedVillagers >= 10)
        {
            multiplicator = 1;
        }

        points *= multiplicator;

        return Mathf.Max(points,0);
    }
}
