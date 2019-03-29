using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDelay : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f;

    private float timeElapsed;

    void Update()
    {
        timeElapsed = -Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(3);
        }
    }
}
