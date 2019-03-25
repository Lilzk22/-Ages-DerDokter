using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Ui Text displays info about interactive object
/// </summary>
public class LookedatInteractiveDisplayText : MonoBehaviour
{
    private IInteractive lookedatInteractive;
    private Text displayText;

    private void Awake()
    {
        displayText = GetComponent<Text>();
        UpdateDiplayText();
    }

    private void UpdateDiplayText()
    {
        if (lookedatInteractive != null)
            displayText.text = lookedatInteractive.DisplayText;
        else
            displayText.text = string.Empty;
    }

    private void OnLookedAtInteractiveChanged(IInteractive newLookedAtInteractive)
    {
        lookedatInteractive = newLookedAtInteractive;
        UpdateDiplayText();
    }

    /// <summary>
    /// Event handler for lookatinteractivechanged
    /// </summary>
    private void OnEnable()
    {
        DetectLookedAtInteractive.LookedAtInteractiveChanged += OnLookedAtInteractiveChanged;
    }
    private void OnDisable()
    {
        DetectLookedAtInteractive.LookedAtInteractiveChanged -= OnLookedAtInteractiveChanged;
    }
}

