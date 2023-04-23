using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public Task task;
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
        FindObjectOfType<AudioMenager>().Play("Warning");
        task.updateTask("Wysluchaj komunikatu");
        yield return new WaitForSecondsRealtime(48); //48 tyle trwa komunikat
        mainDoors.KnockingOnHeavensDoor();
        task.updateTask("Co? Jakie 'istoty'?");
    }
}




