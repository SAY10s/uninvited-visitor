using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knfie : MonoBehaviour, IInteractable
{
    private bool isPickable = false;
    public void activateKnifePickup()
    {
        isPickable = true;
    }
    public void Interact()
    {
        if(isPickable) { 
            gameObject.transform.localScale = new Vector3(0, 0, 0);
            Debug.Log("Podnosisz noz!");
        }
    }
}
