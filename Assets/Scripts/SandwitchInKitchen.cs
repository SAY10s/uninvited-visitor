using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SandwitchInKitchen : MonoBehaviour, IInteractable, HHintable
{
    public GameObject sandwitch;

    public void Hint(GameObject uiObject, TMP_Text text)
    {
        uiObject.SetActive(true);
        text.SetText("Wcisnij 'e' aby zabrac kanapke");
    }

    public void Interact()
    {
        gameObject.transform.localScale = new Vector3(0, 0, 0);
        sandwitch.transform.localScale = new Vector3(0, 0, 0);
    }
}
