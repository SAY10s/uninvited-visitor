using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public Transform location;

    public AudioClip clip;

    public string name;

    [Range(0f, 1f)]
    public float volume; 
    
    [Range(0f, 1f)]
    public float spatialBlend;

    [Range(0.1f, 3f)]
    public float pitch;

    public float minDistance = 1;
    public float maxDistance = 20;

    public bool isLoop = false;

    [HideInInspector]
    public AudioSource source;
}
