using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    string firstLevelName;

    public void ButtonStart()
    {
        //SceneManager.LoadScene(1);
        LoadingScene.LoadNewScene(firstLevelName);
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }
}

