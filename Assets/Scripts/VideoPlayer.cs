using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayer : MonoBehaviour
{
    public GameObject videoPlayer;
    public int timeToStop;

    void Start()
    {
        videoPlayer.SetActive(false);
    }

    void OnTriggerEnter(Collider Player)
    {
        if(Player.gameObject.tag=="Player")
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, timeToStop);
        }
    }
}
