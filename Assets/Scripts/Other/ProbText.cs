using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace Problems
{
public class ProbText : MonoBehaviour
{
    public enum ProbType
    {
        none, SimulEqs
    }

    private readonly Dictionary<ProbType, string> sentences
    = new Dictionary<ProbType, string>()
    {
        { ProbType.SimulEqs, "次の連立方程式を解け。" }
    };

    public ReadOnlyDictionary<ProbType, string> Sentences
    {
        get
        {
            return new ReadOnlyDictionary<ProbType, string>(sentences);
        }
    }
}
}
