using System;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMath : MonoBehaviour
{
    public static int GCM(int x, int y)
    {
        ValueTuple<int,int> divrem = (0, 0);

        if(x > y)
        {
            int tmp = y;
            y = x;
            x = tmp;
        }

        divrem = (x, y % x);

        while(divrem.Item2 != 0)
            divrem = (divrem.Item1, divrem.Item1 % divrem.Item2);


        return divrem.Item1;
    }
}
