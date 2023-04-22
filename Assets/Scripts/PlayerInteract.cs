using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

interface IInteractable
{
    public void Interact();
}
interface HHintable
{
    public void Hint(GameObject uiObject, TMP_Text text);
}

public class PlayerInteract : MonoBehaviour
{
    public float interactRange = 2f;
    public GameObject uiObject;
    private bool showUI = false;
    public TMP_Text text;

    public void Start()
    {
        FindObjectOfType<AudioMenager>().Play("Insane");
        Debug.Log("TASK: Rozejrzyj sie po domu");
        StartCoroutine(Waiter());
        uiObject.SetActive(false);
    }


    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(10);
        Debug.Log("TASK: Zdejmij plaszcz i odloz go do szafy");
    }
    void Update()
    {
        showUI = false;
        if (!showUI)
        {
            uiObject.SetActive(false);
        }
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out HHintable hintable))
            {
                hintable.Hint(uiObject, text);
                showUI = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
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
