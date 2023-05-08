using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimulEqs
{
public class SimulGenConst : MonoBehaviour
{
    #region
    public static int[][] GenWeight = new int[][]
    {
    new int[4] { 65, 35, 0, 0 }
    };

    public enum TargetWeight
    {
        SolutionPattern
    };

    public enum TWExplain
    {
        SP_OneLineMultiply,
        SP_TwoLineMultiply
    };
    #endregion

    private int SUM_MAX = 100;
    public int summax
    {
        get
        {
            return SUM_MAX;
        }
    }



    public static int JagConvert(int value, TargetWeight targetWeight)
    {
        int tw = (int)targetWeight;

        for(int i = 0; i < GenWeight[tw].Length; i++)
        {
            if(value <= GenWeight[tw][i])
                return ++i;
            else
                value += GenWeight[tw][i];
        }
        return 1;
    }
}
}
