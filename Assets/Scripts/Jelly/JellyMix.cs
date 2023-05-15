using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyMix : MonoBehaviour
{
    [SerializeField] GameObject Mixer;

    public void MixActivator()
    {
        Mixer.SetActive(true);
        ButtonEnd.Estimation++;
    }
}
