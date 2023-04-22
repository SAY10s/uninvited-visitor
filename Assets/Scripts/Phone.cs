using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(Waiter());
    }
    public void Interact()
    {
        Debug.Log("RING RING!");
        FindObjectOfType<AudioMenager>().Stop("Ringtone");
        FindObjectOfType<AudioMenager>().Play("Dialogue");
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(5);
        FindObjectOfType<AudioMenager>().Play("Ringtone");
    }
}
