using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactRange = 2f;

    public void Start()
    {
        FindObjectOfType<AudioMenager>().Play("Finally Home");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out Phone phone))
                {
                    phone.Interact();
                }
                if (collider.TryGetComponent(out Knife knife))
                {
                    knife.Interact();
                }
                if (collider.TryGetComponent(out Wardrobe wardrobe))
                {
                    wardrobe.Interact();
                }
            }
        }
    }
}
