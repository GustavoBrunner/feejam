using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Floor : MonoBehaviour
{
    int index = 0;
    public List<Tasks> Tasks = new();

    public UnityEvent StartEvent;

    private void Awake()
    {
        
    }
    public void FinishTask()
    {
        Tasks[index].FireEvent();
        index++;
    }
}
