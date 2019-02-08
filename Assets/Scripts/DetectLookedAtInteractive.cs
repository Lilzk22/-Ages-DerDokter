using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Detects interactive elements the player is looking at
/// </summary>
public class DetectLookedAtInteractive : MonoBehaviour
{
    [Tooltip("Starting Point of Raycast")]
    [SerializeField]
    private Transform raycastOrigin;

    [Tooltip("how far from the the raycast we will serch for interative elemrnts")]
    [SerializeField]
    private float maxRange = 5.0f;

    private void FixedUpdate()
    {
        Debug.DrawRay(raycastOrigin.position, raycastOrigin.forward * maxRange, Color.red);
       
        RaycastHit hitInfo;
        bool objectWasDetected = Physics.Raycast(raycastOrigin.position, raycastOrigin.forward,out hitInfo,maxRange);

        if (objectWasDetected)
        {
           Debug.Log(hitInfo.collider.gameObject.name);
        }
    }
}
