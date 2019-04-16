using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveScript : MonoBehaviour
{
    [SerializeField]
    bool showObjective = false;

    [SerializeField]
    Texture objective;

    [SerializeField]
    private int collision;

    private void Start()
    {
        showObjective = false; 
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && showObjective == false && collision == 0)
            showObjective = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            showObjective = false;
    }

    private void OnGUI()
    {
        if (showObjective == true)
            GUI.DrawTexture(new Rect(Screen.width / 1.5f, Screen.height / 1.4f, 178, 178), objective);
    }

    private void Update()
    {
        if (Input.GetButton("ShowObj") && collision == 1)
        {
            showObjective = true;
        }

        if (Input.GetButtonUp("ShowObj") && collision == 1)
        {
            showObjective = false;
        }
    }       
}
