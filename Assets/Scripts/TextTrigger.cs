using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TextTrigger : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject TheMarker;

    private void OnTriggerEnter(Collider other)
    {
        ThePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = false;
        TheMarker.SetActive(true);
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        TextBox.GetComponent<Text>().text = "Theres a Key on the table";
        yield return new WaitForSeconds(3F);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = true;
        yield return new WaitForSeconds(5F);
        TheMarker.SetActive(false);
    }
}