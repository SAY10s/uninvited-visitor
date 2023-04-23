using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoor : MonoBehaviour, IInteractable, HHintable
{

    public void Hint(GameObject uiObject, TMP_Text text)
    {

            uiObject.SetActive(true);
            text.SetText("Wcisnij 'e' aby wejsc do srodka");
    }

    public void Interact()
    {

        SceneManager.LoadScene("pablo");

    }
}
