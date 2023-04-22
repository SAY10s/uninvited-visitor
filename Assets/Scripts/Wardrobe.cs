using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour, IInteractable
{
    public GameObject player;

    private bool isContaingClothes = false;

    private bool isInside = false;
    public void Interact()
    {
        if (isContaingClothes)
        {
            if (isInside)
            {
                Debug.Log("Wychodzisz z szafy *wink wink*");
                player.transform.position = new Vector3(7.44399977f, -0.00899994373f, 1.43299997f);
            }
            else
            {
                Debug.Log("Wchodzisz do szafy *wink wink*");
                player.transform.position = new Vector3(7.49f, 0.059f, 0.53f);
            }
            isInside = !isInside;
        }
        else
        {
            Debug.Log("Wlozono ciuchy do szafy");
            Debug.Log("Przygotuj sobie cos do jedzenia");
            isContaingClothes = true;
        }
    }
}
