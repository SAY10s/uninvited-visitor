using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwitchInKitchen : MonoBehaviour, IInteractable
{
    public GameObject sandwitch;
    public void Interact()
    {
        gameObject.transform.localScale = new Vector3(0, 0, 0);
        sandwitch.transform.localScale = new Vector3(0, 0, 0);
    }
}
