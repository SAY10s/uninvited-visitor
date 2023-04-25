using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetState : MonoBehaviour
{
    [HideInInspector]
    public bool canPutClothesInside = false;
    public bool isWardrobeHideable = false;
    public bool isSandwitchMakeable = false;
    public bool isDoorKiling = false;
    public bool isDiavoloMoving = false;
    public bool isDoorRunable = false;
    public bool canLeaveWardrobe = true;
    public bool isHiding = false;
    public GameObject character;

    public void jumpScare()
    {
        character.SetActive(true);
        FindObjectOfType<AudioMenager>().Play("JumpScare");
        Time.timeScale = 0;
        StartCoroutine(Waiter());
    }
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene("Menu");
    }
}
