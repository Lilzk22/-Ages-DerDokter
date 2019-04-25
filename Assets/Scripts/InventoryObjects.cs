using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObjects : InteractiveObject
{
    [SerializeField]
    private string objectName = nameof(InventoryObjects);

    [SerializeField]
    [TextArea(1,10)]
    private string description;

    [SerializeField]
    private Sprite icon;

    public Sprite Icon => icon;
    public string ObjectName => objectName;
    public string Description => description;

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
        InventoryMenu.Instance.AddItemToMenu(this);
        renderer.enabled = false;
        collider.enabled = false;

    }
}

