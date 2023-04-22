using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoors : MonoBehaviour
{
    public Light[] lights;
    public Lights XD;
    public void KnockingOnHeavensDoor()
    {

        StartCoroutine(Waiter());

    }
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(10);
        FindObjectOfType<AudioMenager>().Play("Knocking");
        yield return new WaitForSecondsRealtime(20);
        XD.turnOffLightsSound();
        yield return new WaitForSecondsRealtime(1);
        foreach (Light l in lights)
        {
            l.enabled = false;
        }

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
