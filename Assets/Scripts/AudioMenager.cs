using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioMenager : MonoBehaviour
{

    public Sound[] sounds;
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = s.location.gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.spatialBlend = s.spatialBlend;
            s.source.rolloffMode = AudioRolloffMode.Linear;
            s.source.minDistance = s.minDistance;
            s.source.maxDistance = s.maxDistance;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, s => s.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }

    public void Stop(string sound)
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Stop();
    }
}
