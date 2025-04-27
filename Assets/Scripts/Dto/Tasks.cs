using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class Tasks
{
    public UnityEvent onTaskStart;
    public UnityEvent onTaskComplete;

    public int objectiveAmount = 1;
    public int currentAmount = 0;

    public bool IsCompleted => currentAmount >= objectiveAmount;

    public void StartTask()
    {
        currentAmount = 0;
        onTaskStart?.Invoke();
    }

    public void UpdateProgress(int amount)
    {
        currentAmount += amount;
        Debug.Log($"Task progresso: {currentAmount}/{objectiveAmount}");

        if (IsCompleted)
        {
            CompleteTask();
        }
    }

    private void CompleteTask()
    {
        onTaskComplete?.Invoke();
        Debug.Log("Task concluída!");
    }

}
