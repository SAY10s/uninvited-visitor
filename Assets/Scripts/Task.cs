using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Task : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text text2;

    public void updateTask(string taskText)
    {
        text.SetText(taskText);
    }

    public void subtitles(string taskText) {
        text2.SetText(taskText);
    }
}
