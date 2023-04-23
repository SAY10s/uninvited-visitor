using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Waiter());
    }
    IEnumerator Waiter()
    {
        for(float i = 10; i < 40; i++)
        {
            RenderSettings.fogDensity = i / 100; 
            yield return new WaitForSecondsRealtime(3);
        }
        for (float i = 40; i < 70; i++)
        {
            RenderSettings.fogDensity = RenderSettings.fogDensity + .5f;
            yield return new WaitForSecondsRealtime(1);
        }
        RenderSettings.fogDensity = 1;
    }
}