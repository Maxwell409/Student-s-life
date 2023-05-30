using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TextMeshProUGUI counterText;
    [SerializeField] private Button jellyButton;
    [SerializeField] private GameObject jellyText;
    [SerializeField] private Button cakeBitton;
    [SerializeField] private GameObject cakeText;
    // Start is called before the first frame update
    private void Awake()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        counterText = GetComponent<TextMeshProUGUI>();
        counterText.text = string.Format("Опыт: {0:0000}", scoreManager.Score);

        if(scoreManager.Score >= 300)
        {
            jellyButton.interactable = true;
            jellyText.SetActive(false);
        }

        if (scoreManager.Score >= 600)
        {
            cakeBitton.interactable = true;
            cakeText.SetActive(false);
        }
    }
}

