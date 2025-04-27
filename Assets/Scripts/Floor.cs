using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Floor : MonoBehaviour
{
    public List<Tasks> tasks = new();
    public UnityEvent onFloorStart;

    private int currentTaskIndex = 0;
    public Tasks CurrentTask { get; private set; }

    public void StartFloor()
    {
        onFloorStart?.Invoke();
        StartTask();
    }

    private void StartTask()
    {
        if (currentTaskIndex < tasks.Count)
        {
            CurrentTask = tasks[currentTaskIndex];
            CurrentTask.StartTask();
        }
        else
        {
            Debug.Log("Todas as tasks deste andar foram concluídas!");
            // Aqui você pode avisar o EventsController para passar para o próximo andar
        }
    }

    public void UpdateTaskProgress(int amount = 1)
    {
        if (CurrentTask == null) return;

        CurrentTask.UpdateProgress(amount);

        if (CurrentTask.IsCompleted)
        {
            currentTaskIndex++;
            StartTask();
        }
    }
}
