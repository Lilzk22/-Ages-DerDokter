using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detects when player presses interact button while looking at Iinteractive
/// </summary>
public class InteractWithLookedAt : MonoBehaviour
{ 
    private IInteractive lookedAtInteractive;
    void Update()
    {
        if (Input.GetButtonDown("Interact") && lookedAtInteractive != null)
        {
            Debug.Log("Player Interacted");
            lookedAtInteractive.InteractWith();
        }
    }

    private void OnLookedAtInteractiveChanged(IInteractive newLookedAtInteractive)
    {
        lookedAtInteractive = newLookedAtInteractive;
    }

    private void OnEnable()
    {
        DetectLookedAtInteractive.LookedAtInteractiveChanged += OnLookedAtInteractiveChanged;
    }
    private void OnDisable()
    {
        DetectLookedAtInteractive.LookedAtInteractiveChanged -= OnLookedAtInteractiveChanged;
    }
}