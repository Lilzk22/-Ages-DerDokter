using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDelay : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }


    
}
