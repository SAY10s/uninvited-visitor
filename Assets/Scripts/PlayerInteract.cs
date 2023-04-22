using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable
{
    public void Interact();
}

public class PlayerInteract : MonoBehaviour
{
    public float interactRange = 2f;

    public void Start()
    {
        FindObjectOfType<AudioMenager>().Play("Insane");
        Debug.Log("TASK: Rozejrzyj sie po domu");
        StartCoroutine(Waiter());
    }


    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(10);
        Debug.Log("TASK: Zdejmij plaszcz i odloz go do szafy");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            Debug.Log(colliderArray.Length);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out IInteractable interactable))
                {
                    interactable.Interact();
                }
            }
        }
    }
}
