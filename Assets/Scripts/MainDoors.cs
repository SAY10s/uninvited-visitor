using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainDoors : MonoBehaviour, IInteractable, HHintable
{


    public Light[] lights;
    public Lights XD;
    public WindowBreak window;
    public InsideDoor door;
    public Task task;
    public SetState state;
    public Waypointfollower diavolo;
    public void Hint(GameObject uiObject, TMP_Text text)
    {
        if (state.isDoorKiling)
        {
            uiObject.SetActive(true);
            text.SetText("Wcisnij 'e' aby otworzyc drzwi");
        }
        if (!state.isDoorKiling && state.isDoorRunable)
        {
            uiObject.SetActive(true);
            text.SetText("Wcisnij 'e' aby otworzyc drzwi");
        }

    }

    public void Interact()
    {
        if (state.isDoorKiling)
        {
            Debug.Log("U DIE");
            state.jumpScare();
        }
        if (!state.isDoorKiling && state.isDoorRunable)
        {
            SceneManager.LoadScene("Korytarz");
        }
    }

    public void KnockingOnHeavensDoor()
    {
        StartCoroutine(Waiter());
    }
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(10);
        state.isDoorKiling = true;
        FindObjectOfType<AudioMenager>().Play("Knocking");
        yield return new WaitForSecondsRealtime(2);
        task.updateTask("NIE OTWIERAJ DRZWI");
        yield return new WaitForSecondsRealtime(18);
        XD.turnOffLightsSound();
        state.isDoorKiling = false;
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
        yield return new WaitForSecondsRealtime(9);
        state.canLeaveWardrobe = false;
        state.isDiavoloMoving = true;
        diavolo.walk();
        if (!state.isHiding)
        {
            state.jumpScare();
        }
        
        yield return new WaitForSecondsRealtime(10);
        state.canLeaveWardrobe = true;
        state.isDoorRunable = true;
        task.updateTask("NIE ROZGLADAJ SIE. UCIEKAJ. TERAZ.");
        yield return new WaitForSecondsRealtime(10);
        state.jumpScare();
    }
}
