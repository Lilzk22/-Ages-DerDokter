using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSetActive : InteractiveObject
{
    [Tooltip("Game object to toggle")]
    [SerializeField]
    private GameObject objectToToggle;

    [SerializeField]
    private bool isReusable = true;

    private bool hasBeenUsed = false;

    /// <summary>
    /// Toggles activeself value for the objectToToggle
    /// </summary>
    public override void InteractWith()
    {
        if (isReusable)
        {
           base.InteractWith();
            objectToToggle.SetActive(objectToToggle.activeSelf);
            hasBeenUsed = true;
            if (!isReusable) displayText = string.Empty;
        }

    }
   
}
