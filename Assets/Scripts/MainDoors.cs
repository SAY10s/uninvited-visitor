using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoors : MonoBehaviour
{
    public Light[] lights;
    public Lights XD;
    public WindowBreak window;
    public InsideDoor door;
    public Task task;
    public void KnockingOnHeavensDoor()
    {
        StartCoroutine(Waiter());
    }
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(10);
        FindObjectOfType<AudioMenager>().Play("Knocking");
        yield return new WaitForSecondsRealtime(2);
        task.updateTask("NIE OTWIERAJ DRZWI");
        yield return new WaitForSecondsRealtime(18);
        XD.turnOffLightsSound();
        task.updateTask("SCHOWAJ SIE");
        yield return new WaitForSecondsRealtime(1);
        foreach (Light l in lights)
        {
            l.enabled = false;
        }
        yield return new WaitForSecondsRealtime(5);
        window.breakWindow();
        yield return new WaitForSecondsRealtime(5);
        door.breakDoor();
    }
}
