using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour, IInteractable
{
    public GameObject player;
    private bool isInside = false;
    public void Interact()
    {
        if (isInside)
        {
            player.transform.position = new Vector3(7.44399977f, -0.00899994373f, 1.43299997f);
        }
        else
        {
            player.transform.position = new Vector3(7.49f, 0.059f, 0.53f);
        }
        isInside = !isInside;
        Debug.Log("Wardrobe");
    }
}
