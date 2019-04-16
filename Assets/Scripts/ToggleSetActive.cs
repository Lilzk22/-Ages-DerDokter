using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSetActive : InteractiveObject
{
    [Tooltip("Game object to toggle")]
    [SerializeField]
    private GameObject objectToToggle;
    private GameObject objectToToggle1;
    private GameObject objectToToggle2;
    private GameObject objectToToggle3;
    private GameObject objectToToggle4;
    private GameObject objectToToggle5;



    [SerializeField]
    private bool isReusable = true;

    private bool hasBeenUsed = false;

    /// <summary>
    /// Toggles activeself value for the objectToToggle
    /// </summary>
    public override void InteractWith()
    {
        if (isReusable || !hasBeenUsed)
        {
            base.InteractWith();
            objectToToggle.SetActive(!objectToToggle.activeSelf);
            hasBeenUsed = true;
            if (!isReusable) displayText = string.Empty;
        }

    }

}

