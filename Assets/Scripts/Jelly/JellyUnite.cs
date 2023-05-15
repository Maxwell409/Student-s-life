using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyUnite : MonoBehaviour
{
    [SerializeField] private GameObject[] planes;

    [SerializeField] private GameObject buttonMix;
    [SerializeField] private GameObject buttonCold;

    [SerializeField] private Material[] materials;

    private int gelatinCount = 0;
    private int cupCount = 0;
    private int juiceCount = 0;

    private bool layer0Check;
    public bool Layer0Check
    {
        get { return layer0Check; }
        set
        {
            layer0Check = value;
            planes[0].SetActive(value);
        }
    }

    private bool layer1Check;
    public bool Layer1Check
    {
        get { return layer1Check; }
        set
        {
            layer1Check = value;
            planes[1].SetActive(value);
        }
    }

    private bool layer2Check;
    public bool Layer2Check
    {
        get { return layer2Check; }
        set
        {
            layer2Check = value;
            planes[2].SetActive(value);
        }
    }

    private int ingredientÑounter;
    public int IngredientÑounter
    {
        get { return ingredientÑounter; }
        set
        {
            ingredientÑounter = value;
            if (value > 3)
                ButtonEnd.Estimation--;
        }
    }


    public void DyeMethod(string name)
    {
        switch (IngredientÑounter)
        {
            case 0:
                Layer0Check = true;
                JellyColor(0, name);
                break;

            case 1:
                Layer1Check = true;
                JellyColor(1, name);
                break;

            case 2:
                Layer2Check = true;
                JellyColor(2, name);
                buttonCold.SetActive(true);
                buttonMix.SetActive(true);
                break;
        }
    }

    private void JellyColor(int indexLayer, string name)
    {
        switch (name) // áàã: ñ íåïğàâèëüíûì ïîğÿäêîì íå äàåò öâåò
        {
            case "Gelatin":
                planes[indexLayer].GetComponent<Renderer>().material = materials[0];
                IngredientÑounter++;
                gelatinCount++;
                ButtonEnd.Estimation++;
                if (gelatinCount > 1)
                    ButtonEnd.Estimation -= 2;
                break;

            case "Cup":
                planes[indexLayer].GetComponent<Renderer>().material = materials[1];
                IngredientÑounter++;
                cupCount++;
                ButtonEnd.Estimation++;
                if (cupCount > 1)
                    ButtonEnd.Estimation -= 2;
                break;

            case "Juice":
                planes[indexLayer].GetComponent<Renderer>().material = materials[2];
                IngredientÑounter++;
                juiceCount++;
                ButtonEnd.Estimation++;
                if (juiceCount > 1)
                    ButtonEnd.Estimation -= 2;
                break;
        }
    }
}
