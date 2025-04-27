using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsController : MonoBehaviour
{
    public List<Floor> floors = new();

    private int currentFloorIndex = 0;
    public Floor CurrentFloor { get; private set; }

    private void Start()
    {
        StartFloor();
    }

    public void StartFloor()
    {
        if (currentFloorIndex < floors.Count)
        {
            CurrentFloor = floors[currentFloorIndex];
            CurrentFloor.StartFloor();
        }
    }

    public void NextFloor()
    {
        currentFloorIndex++;
        StartFloor();
    }
}
