using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void ObjectActive(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

    public void SceneLoader(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Exit()
    {
        Application.Quit();
    }
}