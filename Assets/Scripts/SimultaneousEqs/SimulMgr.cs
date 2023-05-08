using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Problems;
using SimulEqs;

using ProbType     = Problems.ProbText.ProbType;
using TargetWeight = SimulEqs.SimulGenConst.TargetWeight;
using TWExplain    = SimulEqs.SimulGenConst.TWExplain;

namespace SimulEqs
{
//Types of magic number: 2
public class SimulMgr : MonoBehaviour
{
    private static ProbType probType = ProbType.SimulEqs;
    private SimulValue simulValue;
    private StringBuilder probText;
    private StringBuilder eqsText;

    public void Answer()
    {}

    public void Generate()
    {
        int i;

        i = Randoms.Percent();
        var _sp  = (TWExplain)SimulGenConst.JagConvert(i, TargetWeight.SolutionPattern);
    }

    private void AssignNum(ref SimulValue simulvalue, TWExplain sp)
    {
    }
}
}
