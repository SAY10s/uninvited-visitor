using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wardrobe : MonoBehaviour, IInteractable, HHintable
{

    public SetState state;

    public GameObject player;
    public string hintText = "PLACEHOLDER";

    private bool isContaingClothes = false;

    private bool isInside = false;

    public Task task;

    public void Hint(GameObject ui, TMP_Text text)
    {   
        if (state.canPutClothesInside) { 

                ui.SetActive(true);
           

            text.SetText(hintText);
        }
    }

    public void Interact()
    {
        if(state.canPutClothesInside) { 
            if (isContaingClothes)
            {
                if (isInside)
                {
                    player.transform.position = new Vector3(7.44399977f, -0.00899994373f, 1.43299997f);
                    hintText = "Press 'e' to enter the wardrobe";
                    state.isHiding = false;
                    if (!state.canLeaveWardrobe)
                    {
                        state.jumpScare();
                    }
                }
                else
                {
                    state.isHiding = true;
                    player.transform.position = new Vector3(7.49f, 0.059f, 0.53f);
                    hintText = "Press 'e' to exti the wardrobe";
                }
                isInside = !isInside;
            }
            else
            {
                task.updateTask("Get yourself something to eat");
                hintText = "Press 'e' to enter the wardrobe";
                isContaingClothes = true;
                state.isSandwitchMakeable = true;
            }
        }
    }
}
