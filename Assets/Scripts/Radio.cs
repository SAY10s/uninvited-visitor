using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour, IInteractable
{
    private bool isPlaying = true;
    void Start()
    {
        FindObjectOfType<AudioMenager>().Play("Heartaches");
    }
    public void Interact()
    {
        if (isPlaying)
        {
            FindObjectOfType<AudioMenager>().Stop("Heartaches");
        }
        else
        {
            FindObjectOfType<AudioMenager>().Play("Heartaches");
        }
        isPlaying = !isPlaying;
        Debug.Log("Radio");
    }
}
