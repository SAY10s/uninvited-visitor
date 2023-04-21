using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public void Start()
    {
        FindObjectOfType<AudioMenager>().Play("Ringtone");
    }
    public void Interact()
    {
        Debug.Log("RING RING!");
        FindObjectOfType<AudioMenager>().Stop("Ringtone");
        FindObjectOfType<AudioMenager>().Play("Dialogue");

    }
}
