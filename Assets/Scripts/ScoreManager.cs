using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance;
    /// <summary>
    /// C������� ��� �������������� ����������� ������� 
    /// </summary>
    public static ScoreManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private int score = 0;
    /// <summary>
    /// ���� ������� ����� �����
    /// </summary>
    public int Score
    {
        get { return score; }
        set 
        { 
            if(value != 0)
            {
                score = value;
            }
        }
    }
}