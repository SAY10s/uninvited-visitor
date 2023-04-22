using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideDoor : MonoBehaviour
{
    public void breakDoor()
    {
        FindObjectOfType<AudioMenager>().Play("breakDoor");
    }
}
