using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablesManager : MonoBehaviour
{
    [SerializeField]private GameManager gameManager;
    [SerializeField]private DropPlaceScript[] dropPlaceScripts;
    [SerializeField]private DropPlaceScript[] dropPlaceScripts1;
    [SerializeField]private DropPlaceScript[] dropPlaceScripts2;

    public void TablesChecked()
    {
        for (int i = 0; i < dropPlaceScripts.Length; i++)
        {
            if (!dropPlaceScripts[i].CardCheck)
            {
                print(dropPlaceScripts[i].CardCheck);
                GameManager.Estimation--;
                break;
            }
            print(dropPlaceScripts[i].CardCheck);
        }
        for (int i = 0; i < dropPlaceScripts1.Length; i++)
        {
            if (!dropPlaceScripts1[i].CardCheck)
            {
                print(dropPlaceScripts[i].CardCheck);
                GameManager.Estimation--;
                break;
            }
            print(dropPlaceScripts1[i].CardCheck);
        }
        for (int i = 0; i < dropPlaceScripts2.Length; i++)
        {
            if (!dropPlaceScripts2[i].CardCheck)
            {
                print(dropPlaceScripts[i].CardCheck);
                GameManager.Estimation--;
                break;
            }
            print(dropPlaceScripts2[i].CardCheck);
        }

        //foreach (var dropPlaceScript in dropPlaceScripts)
        //{
        //    if (dropPlaceScript.CardCheck)
        //    {
        //        GameManager.Estimation--;
        //        break;
        //    }
        //    print(dropPlaceScript.CardCheck);
        //}
        //foreach (var dropPlaceScript in dropPlaceScripts1)
        //{
        //    if (dropPlaceScript.CardCheck)
        //    {
        //        GameManager.Estimation--;
        //        break;
        //    }
        //    print(dropPlaceScript.CardCheck);

        //}
        //foreach (var dropPlaceScript in dropPlaceScripts2)
        //{
        //    if (dropPlaceScript.CardCheck)
        //    {
        //        GameManager.Estimation--;
        //        break;
        //    }
        //    print(dropPlaceScript.CardCheck);
        //}
        gameManager.GameEnd();
    }
}
