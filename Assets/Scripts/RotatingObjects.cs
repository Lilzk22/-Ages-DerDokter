using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObjects : MonoBehaviour
{
    public GameObject gearOne;

    void Update()
    {
        gearOne.transform.Rotate(0, 1, 0);
    }
}
