using System;
using System.Collections.Generic;
using UnityEngine;

namespace SimulEqs
{
public class SimulValue : MonoBehaviour
{
    public int x { get; set; }
    public int y { get; set; }
    public int[,] coef = new int[2,2];
    

    public int[] Sum()
    {
        var value = new int[2];

        for(int i = 0; i < 2; i++)
            value[i] = (x * coef[i,0]) + (y * coef[i,1]);
    

        return value;
    }

    public string[] EqsText()
    {
        var value = new string[2];
        
        int[] sum = Sum();
        for(int i = 0; i < 2; i++)
            value[i] = $"{SignedNumber(coef[i,0], true)}x {SignedNumber(coef[i,1])}y = {SignedNumber(sum[i], true)}";


        return value;
    }

    private string SignedNumber(int x, bool istop = false)
    {
        switch(x)
        {
            case -1:
                return "-";
            case int i when i < -1:
                return x.ToString();
            case 1:
                return  istop ? "" : "+";
            case int i when i > 1:
                return (istop ? "" : "+") + x.ToString();
            default:
                throw new Exception("error");
        }
    }

}
}
