using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObjects : InteractiveObject
{
    [SerializeField]
    private string objectName = nameof(InventoryObjects);

     
    [SerializeField]
    public string ObjectName => objectName;

    private new Renderer renderer;
    private new Collider collider;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
    }


    public InventoryObjects()
    {
        displayText = $"Take {objectName}";
    }
    public override void InteractWith()
    {
        base.InteractWith();
        PlayerInventory.InventoryObjects.Add(this);
        renderer.enabled = false;
        collider.enabled = false;

    }
}

