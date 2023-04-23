using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public void turnOffLightsSound()
    {
        FindObjectOfType<AudioMenager>().Play("BreakingLight");
        Debug.Log("Turning off lights");
    }
}
