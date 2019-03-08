using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   //public bool quit = false;

   // public void OnMouseEnter()
   // {

   //     GetComponent<MeshRenderer>().material.color = Color.red;

   // }

   // public void OnMouseExit()
   // {

   //     GetComponent<MeshRenderer>().material.color = Color.white;

   // }

   // public void OnMouseUp()
   // {

   //     if (quit == true)
   //     {
   //         Application.Quit();
   //     }
   //     else
   //     {
   //         Application.LoadLevel(1);
   //     }

   // }

   // public void Update()
   // {
   //     if (Input.GetKey(KeyCode.Escape))
   //     {
   //         Application.Quit();
   //     }

   // }
    public void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonCredit()
    {
        SceneManager.LoadScene(2);
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }
}
