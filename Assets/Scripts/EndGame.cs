using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] private ScoreManager scoreManager;

    private void Awake()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public void ShowEstimation(int estimation)
    {
        gameObject.SetActive(true);
        text.text = "Ваша оценка: " + estimation;
        scoreManager.Score += estimation * 100;
    }
}