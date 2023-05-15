using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ColliderTriggerManager : MonoBehaviour
{
    [SerializeField]private ColliderScript[] scripts;
    [SerializeField]private EndGame endGameScript;
    [SerializeField] private GameObject colliders;

    private int estimation = 5;

    public void EndButton()
    {
        colliders.SetActive(true);
        StartCoroutine(ColliderCheck());
    }

    IEnumerator ColliderCheck()
    {
        yield return new WaitForSeconds(0.1f);

        foreach (var script in scripts)
        {
            if (script.filledIn == false)
            {
                if (estimation > 2)
                {
                    estimation--;
                    print(estimation);
                }
            }
        }
        endGameScript.ShowEstimation(estimation);
    }
}
