using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Knfie : MonoBehaviour, IInteractable, HHintable
{
    private bool isPickable = false;
    private bool showHint = false;
    public void activateKnifePickup()
    {
        isPickable = true;
    }

    public void Hint(GameObject uiObject, TMP_Text text)
    {
        if(isPickable && !showHint)
        {
            uiObject.SetActive(true);
            text.SetText("Wcisnij 'e' aby podniesc noz");
        }
    }

    public void Interact()
    {
        if(isPickable) { 
            gameObject.transform.localScale = new Vector3(0, 0, 0);
            showHint = true;
            Debug.Log("Podnosisz noz!");
        }
    }
}
