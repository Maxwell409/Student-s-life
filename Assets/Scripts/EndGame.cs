using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    private static int estination;

    [SerializeField] GameObject panel;
    [SerializeField] Text text;

    public void ShowEstimation()
    {
        panel.SetActive(true);
    }
}
