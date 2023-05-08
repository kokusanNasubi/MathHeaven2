using System;
using System.Collections.Generic;
using UnityEngine;

namespace Problems
{
public class Randoms : MonoBehaviour
{
    public static int Percent()
    {
        return UnityEngine.Random.Range(1, 100);
    }

    public static int Random(int min, int max)
    {
        return UnityEngine.Random.Range(min, max);
    }

    public static int ExceptRandom(int min, int max, params int[] exceptnums)
    {
        #region
        if(min > max)
        {
            int tmp = max;
            max     = min;
            min     = tmp;
        }

        if((max - min) <= exceptnums.Length)
            throw new Exception("error");
        #endregion

        int i;

        while(true)
        {
            i = UnityEngine.Random.Range(min, max);
            if(Array.Exists(exceptnums, x => x == i))
                continue;

            return i;
        }
    }
}
}
