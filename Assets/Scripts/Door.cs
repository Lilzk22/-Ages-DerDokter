using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{
    [SerializeField]
    private InventoryObjects key;
    [SerializeField]
    private bool consumeKey;
    [SerializeField]
    private string lockedDisplayText = "Locked";
    [SerializeField]
    private AudioClip lockedAudioClip;
    [SerializeField]
    private AudioClip openAudioClip;

    //public override string DisplayText => isLocked ? lockedDisplayText : base.DisplayText;

    public override string DisplayText
    {
        get
        {
            string toReturn;
            if (isLocked)
                toReturn = HasKey ? $"Use{key.ObjectName}" : lockedDisplayText;
            else
                toReturn = base.DisplayText;
            return toReturn;
        }
    }

    private bool HasKey => PlayerInventory.InventoryObjects.Contains(key);
    private Animator animator;
    private bool isOpen = false;
    private bool isLocked;
    private int shouldOpenAnimParameter = Animator.StringToHash(nameof(shouldOpenAnimParameter));

    public Door()
    {
        displayText = nameof(Door);
    }

    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
        Intialize();
    }

    private void Intialize()
    {
        if (key != null)
        {
            isLocked = true;
        }
    }

    public override void InteractWith()
    {
        if (!isOpen)
        {

            if (isLocked && !HasKey)
            {
                audioSource.clip = lockedAudioClip;
            }
            else
            {
                audioSource.clip = openAudioClip;
                animator.SetBool("shouldOpen", true);
                displayText = string.Empty;
                isOpen = true;
                UnlockDoor();
            }
            base.InteractWith();
        }
    }

    private void UnlockDoor()
    {
        isLocked = false;
        if (key != null && consumeKey)
            PlayerInventory.InventoryObjects.Remove(key);
    }
}

