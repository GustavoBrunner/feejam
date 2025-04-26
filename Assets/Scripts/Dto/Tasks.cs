using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class Tasks
{
    public UnityEvent taskEvent;
    public int Objective;
    public void FireEvent()
    {
        taskEvent.Invoke();
    }
}
