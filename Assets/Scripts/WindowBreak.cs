using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowBreak : MonoBehaviour
{
    public void breakWindow()
    {
        FindObjectOfType<AudioMenager>().Play("Window");
    }
}
