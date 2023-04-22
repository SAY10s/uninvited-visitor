using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sofa : MonoBehaviour, IInteractable
{
    public CapsuleCollider playerCollider;
    public GameObject player;
    FirstPersonMovement movement;
    private bool isSitting = false;

    public void Awake()
    {
        movement = player.GetComponent<FirstPersonMovement>();
    }
    public void Interact()
    {
        if (!isSitting) { 
            Debug.Log("Siadasz");
            playerCollider.height = .5f;
            player.transform.position = new Vector3(4.0964489f, 0.203867197f, 4.37153769f);
            movement.speed = 0f;
        }
        else
        {
            Debug.Log("Wstajesz");
            playerCollider.height = 1.8f;
            player.transform.position = new Vector3(5, 0.231000006f, 3.95799994f);
            movement.speed = 2f;
        }
    }
}
