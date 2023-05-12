using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyUnite : MonoBehaviour
{
    [SerializeField] private GameObject[] planes;

    [SerializeField] private GameObject buttonMix;
    [SerializeField] private GameObject buttonCold;

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
        get { return layer0Check; }
        set
        {
            layer0Check = value;
            planes[1].SetActive(value);
        }
    }

    private bool layer2Check;
    public bool Layer2Check
    {
        get { return layer0Check; }
        set
        {
            layer0Check = value;
            planes[2].SetActive(value);
        }
    }

    private int ingredient—ounter = 0;

    [SerializeField] private Material[] materials;

    //private void PlanesActivator(Material material1, Material material2, Material material3, Material material4)
    //{
    //    if (planesCheck[0])
    //    {
    //        if (planesCheck[1])
    //        {
    //            if (planesCheck[2])
    //            {
    //                planesCheck[3] = true;
    //                planes[3].SetActive(true);
    //                planes[3].GetComponent<Renderer>().material = material;
    //                return;
    //            }

    //            planesCheck[2] = true;
    //            planes[2].SetActive(true);
    //            planes[2].GetComponent<Renderer>().material = material;
    //            return;
    //        }

    //        planesCheck[1] = true;
    //        planes[1].SetActive(true);
    //        planes[1].GetComponent<Renderer>().material = material;
    //        return;
    //    }
    //    else
    //    {
    //        planesCheck[0] = true;
    //        planes[0].SetActive(true);
    //        planes[0].GetComponent<Renderer>().material = material;
    //    }
    //}

    public void DyeMethod(string name)
    {
        switch (name) // ·‡„: Ò ÌÂÔ‡‚ËÎ¸Ì˚Ï ÔÓˇ‰ÍÓÏ ÌÂ ‰‡ÂÚ ˆ‚ÂÚ
        {
            case "Gelatin":
                if (ingredient—ounter == 0)
                    planes[ingredient—ounter].GetComponent<Renderer>().material = materials[0];
                JellyColor();
                ingredient—ounter++;
                break;

            case "Cup":
                if (ingredient—ounter <= 1)
                    planes[ingredient—ounter].GetComponent<Renderer>().material = materials[1];
                JellyColor();
                ingredient—ounter++;
                break;

            case "Juice":
                if (ingredient—ounter <= 2)
                    planes[ingredient—ounter].GetComponent<Renderer>().material = materials[2];
                JellyColor();
                ingredient—ounter++;
                break;
        }
    }

    private void JellyColor()
    {
        switch (ingredient—ounter)
        {
            case 0:
                Layer0Check = true;
                break;

            case 1:
                Layer1Check = true;
                break;

            case 2:
                Layer2Check = true;
                buttonCold.SetActive(true); 
                buttonMix.SetActive(true);
                break;
        }
    }
}
