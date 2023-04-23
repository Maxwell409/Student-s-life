using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableClear : MonoBehaviour
{
    public void ClearMethod()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("ForRepainting");

        if(gameObjects != null)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                Destroy(gameObject);
            }
        }
    }
}
