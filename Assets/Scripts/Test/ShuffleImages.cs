using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShuffleImages : MonoBehaviour
{
    [SerializeField]private List<Image> images;

    private void Start()
    {
        Shuffle();
    }

    private void Shuffle()
    {
        // ������������ ������ �����������
        for (int i = 0; i <images.Count; i++)
        {
            int randomIndex = Random.Range(i, images.Count);
            Image temp = images[i];
            images[i] = images[randomIndex];
            images[randomIndex] = temp;
        }

        // ���������������� ����������� � ������
        for (int i = 0; i < images.Count; i++)
        {
            images[i].transform.SetSiblingIndex(i);
        }
    }
}