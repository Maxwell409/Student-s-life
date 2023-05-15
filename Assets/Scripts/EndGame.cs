using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    public void ShowEstimation(int estimation)
    {
        gameObject.SetActive(true);
        text.text = "Ваша оценка: " + estimation;
    }
}
