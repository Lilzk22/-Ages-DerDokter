using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenuItemToggle : MonoBehaviour
{
    [SerializeField]
    private Image iconImage;

    public static event Action<InventoryObjects> InventoryMenuItemSelected;

    private InventoryObjects associatedInventoryObject;

    public InventoryObjects AssociatedInventoryObject
    {
        get { return associatedInventoryObject; }
        set
        {
            associatedInventoryObject = value;
            iconImage.sprite = associatedInventoryObject.Icon;
        }
    }

    /// <summary>
    /// This will be plugged into toggles on value changed property in editor and called when toggle is clicked
    /// </summary>
    public void InventoryItemWasToggled(bool isOn)
    {
        if (isOn)
            InventoryMenuItemSelected?.Invoke(AssociatedInventoryObject);
        Debug.Log($"toggled:{isOn}");
    }
    private void Awake()
    {
        Toggle toggle = GetComponent<Toggle>();
        ToggleGroup toggleGroup = GetComponentInParent<ToggleGroup>();
        toggle.group = toggleGroup;
    }
}
