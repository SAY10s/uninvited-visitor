using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public GameObject knife;
    public void Interact()
    {
        knife.transform.localScale = new Vector3(0,0,0);
        Debug.Log("CUT CUT CUT!");
    }
}
