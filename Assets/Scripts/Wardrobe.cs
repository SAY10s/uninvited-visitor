using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    public GameObject player;
    private bool isInside = false;
    public void Interact()
    {
        if (isInside)
        {
            player.transform.position = new Vector3(5.8f, 0f, 0f);
        }
        else
        {
            player.transform.position = new Vector3(7.27f, 0.55f, 0f);
        }
        isInside = !isInside;
        Debug.Log("Wardrobe");
    }
}
