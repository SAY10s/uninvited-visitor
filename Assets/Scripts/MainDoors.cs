using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoors : MonoBehaviour
{
    public void KnockingOnHeavensDoor()
    {

        StartCoroutine(Waiter());

    }
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(10);
        FindObjectOfType<AudioMenager>().Play("Knocking");
    }
    /*
    public void Start()
    {
        StartCoroutine(Waiter());
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(10);
        FindObjectOfType<AudioMenager>().Play("Knocking");
    }
    */
}