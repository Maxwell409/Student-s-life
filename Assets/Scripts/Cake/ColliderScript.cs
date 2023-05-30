using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    [SerializeField] string nameObj;

    public bool filledIn = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == nameObj)
        {
            filledIn = true;
        }
    }
}
