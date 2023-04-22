using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Task : MonoBehaviour
{
    public TMP_Text text;

    public void updateTask(string taskText)
    {
        text.SetText(taskText);
    }
}
