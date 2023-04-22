using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wardrobe : MonoBehaviour, IInteractable, HHintable
{
    public GameObject player;
    public string hintText = "PLACEHOLDER";

    private bool isContaingClothes = false;

    private bool isInside = false;

    public void Hint(GameObject ui, TMP_Text text)
    {
        Debug.Log("P");
        ui.SetActive(true);
        text.SetText(hintText);
    }

    public void Interact()
    {
        if (isContaingClothes)
        {
            if (isInside)
            {
                Debug.Log("Wychodzisz z szafy *wink wink*");
                player.transform.position = new Vector3(7.44399977f, -0.00899994373f, 1.43299997f);
                hintText = "Wcisnij 'e' aby wejsc do szafy";
            }
            else
            {
                Debug.Log("Wchodzisz do szafy *wink wink*");
                player.transform.position = new Vector3(7.49f, 0.059f, 0.53f);
                hintText = "Wcisnij 'e' aby wyjsc z szafy";
            }
            isInside = !isInside;
        }
        else
        {
            Debug.Log("Wlozono ciuchy do szafy");
            Debug.Log("Przygotuj sobie cos do jedzenia");
            hintText = "Wcisnij 'e' aby wejsc do szafy";
            isContaingClothes = true;
        }
    }
}
