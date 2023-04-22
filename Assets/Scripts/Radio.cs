using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public MainDoors mainDoors;
    void Start()
    {
        FindObjectOfType<AudioMenager>().Play("Heartaches");
    }

    public void WarnAboutEntities()
    {
        StartCoroutine(Waiter());

    }
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(10);
        FindObjectOfType<AudioMenager>().Stop("Heartaches");
        //FindObjectOfType<AudioMenager>().Play("Warning");
        yield return new WaitForSecondsRealtime(1); //tyle trwa komunikat
        mainDoors.KnockingOnHeavensDoor();

    }
}




