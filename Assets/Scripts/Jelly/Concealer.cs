using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Concealer : MonoBehaviour
{
    [SerializeField] float timeToDeactivate = 1;
    [SerializeField] private JellyUnite jellyUniteScript;
    [SerializeField] bool Need = true;
    private void OnEnable()
    {
        StartCoroutine(Deactivator());
    }

    IEnumerator Deactivator()
    {
        print("Корутина запущена");
        if(Need)
            jellyUniteScript.DyeMethod(gameObject.name);
        yield return new WaitForSeconds(timeToDeactivate);
        gameObject.SetActive(false);
    }
}
