using System.Collections.Generic;
using UnityEngine;

public class DDOnLoad : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
