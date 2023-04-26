using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sofa : MonoBehaviour, IInteractable, HHintable
{
    public CapsuleCollider playerCollider;
    public Radio radio;
    public GameObject player;
    public Knfie knfie;
    FirstPersonMovement movement;
    private bool isSitting = false;
    public bool wolnoMuSiadac = false;
    private string hintText = "Press 'e' to sit down";
    public Task task;

    public void Awake()
    {
        movement = player.GetComponent<FirstPersonMovement>();
        wolnoMuSiadac = false;
    }
    public void Start()
    {
        wolnoMuSiadac = false;
    }

    public void Hint(GameObject uiObject, TMP_Text text)
    {
        if(wolnoMuSiadac)
        {
            uiObject.SetActive(true);
            text.SetText(hintText);
        }

    }

    public void Interact()
    {
        if (!isSitting && wolnoMuSiadac) { 
            playerCollider.height = .5f;
            player.transform.position = new Vector3(4.0964489f, 0.203867197f, 4.37153769f);
            movement.speed = 0f;
            isSitting=true;
            knfie.activateKnifePickup();
            radio.WarnAboutEntities();
            hintText="Press e to get up";
            task.updateTask("Relax and listen to the radio");
        }
        else if (wolnoMuSiadac)
        {
            playerCollider.height = 1.8f;
            player.transform.position = new Vector3(5, 0.231000006f, 3.95799994f);
            movement.speed = 2f;
            isSitting=false;
            wolnoMuSiadac=false;
        }
    }
}
