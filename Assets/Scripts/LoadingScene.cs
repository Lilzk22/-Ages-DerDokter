using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    [SerializeField]
    Slider progressSlider;

    const string loadingSceneName = "DreamBox";

    private static string sceneToLoad;

     void Start()
     {
        progressSlider.value = 0;
        StartCoroutine(BeginLoading());
     }

    public static void LoadNewScene(string sceneToLoad)
    {
        LoadingScene.sceneToLoad = sceneToLoad;
        SceneManager.LoadScene(loadingSceneName);
    }

    private IEnumerator BeginLoading()
    {
        yield return new WaitForSeconds(1f);
       AsyncOperation async = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Additive);

        while (!async.isDone)
        {
            progressSlider.value = async.progress;

            yield return null;
        }
        progressSlider.value = async.progress;
        yield return new WaitForSeconds(1f);
        SceneManager.UnloadScene(loadingSceneName);
    }
}
