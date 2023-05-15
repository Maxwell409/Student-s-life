using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private EndGame endGameScript;

    private void Awake()
    {
        endGameScript = GameObject.Find("EndPanel").GetComponent<EndGame>();
        endGameScript.gameObject.SetActive(false);
    }
    private static int estimation = 5;
    public static int Estimation
    {
        get { return estimation; }
        set
        {
            if(value > 0)
                estimation = value;

            print(estimation+" оценка");
        }
    }

    public void GameEnd()
    {
        endGameScript.ShowEstimation(estimation);
    }
}
