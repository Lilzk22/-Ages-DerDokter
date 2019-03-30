using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuioTrigger : MonoBehaviour
{
    public AudioClip SoundPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter()
    {
       if(!alreadyPlayed)
       {
            audio.PlayOneShot(SoundPlay, Volume);
            alreadyPlayed = true;
       }
    }
}
