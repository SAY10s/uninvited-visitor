using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMaking : MonoBehaviour, IInteractable
{
    public GameObject sandwitch;
    public GameObject knife;

    public void Interact()
    {
        gameObject.transform.localScale = new Vector3 (0, 0, 0);
        sandwitch.transform.localScale = new Vector3(0.0855129287f, 0.0855129138f, 0.0855128989f);
        knife.transform.localScale = new Vector3(0.0109323096f, 0.0101554291f, 0.0121772969f);
        //knife.transform.position = new Vector3(-21.4500008f, 0.531000018f, -41.0050011f);
        knife.transform.rotation = Quaternion.Euler(270f, 151.314514f, 0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        sandwitch.transform.localScale = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
