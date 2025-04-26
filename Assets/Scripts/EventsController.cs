using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsController : MonoBehaviour
{
    int index = 0;
    public List<Floor> Floors = new();

    public void StartFloor()
    {
        Floors[index].StartEvent.Invoke();
    }
    public void NextFloor()
    {
        index++;
        Floors[index].StartEvent.Invoke();
    }
}
