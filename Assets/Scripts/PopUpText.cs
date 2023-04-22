using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpText : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text popupText;

    private GameObject window;
    private Animator PopUpAnimator;

    private Queue<string> popupQueue;
    private Coroutine queueChecker;

    private void Start(){
        window = transform.GetChild(0).gameObject;
        PopUpAnimator = window.GetComponent<Animator>();
        window.SetActive(false);
        popupQueue = new Queue<string>();
    }

    public void AddToQueue(string text){
        popupQueue.Enqueue(text);
        if(queueChecker == null)
            queueChecker = StartCoroutine(CheckQueue());
    }

    private void ShowPopup(string text){
        window.SetActive(true);
        popupText.text = text;
        PopUpAnimator.Play("PopUpAnimation");
    }

    private IEnumerator CheckQueue(){
        do {
            ShowPopup(popupQueue.Dequeue());
            do {
                yield return null;
            } while(!PopUpAnimator.GetCurrentAnimatorStateInfo(0).IsTag("idle"));
        } while(popupQueue.Count > 0);
        window.SetActive(false);
        queueChecker = null;
    }
}
