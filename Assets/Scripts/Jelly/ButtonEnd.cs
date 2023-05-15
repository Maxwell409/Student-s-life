using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnd : MonoBehaviour
{
    [SerializeField]private EndGame endGameScript;
    public static int Estimation = 1;
    public void EndMethod()
    {
        endGameScript.ShowEstimation(Estimation);
    }
}
