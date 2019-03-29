using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundRandomizer : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioMixerGroup output;

    public float minPitch = .5f;
    public float maxPitch = 1.5f;


    void Update()
    {
        if(Input.GetKeyDown("mouse 0"))
        {
            PlaySound();
        }
    }

    void PlaySound()
    {
        int randomClip = Random.Range(0, clips.Length);
        AudioSource source = gameObject.AddComponent<AudioSource>();
        source.clip = clips[randomClip];
        source.outputAudioMixerGroup = output;
        source.pitch = Random.Range(minPitch, maxPitch);
        source.Play();
        Destroy(source, clips[randomClip].length);
        
    }
}
