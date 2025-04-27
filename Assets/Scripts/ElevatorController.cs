using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ElevatorController : MonoBehaviour
{
    private Animator _animator;

    public UnityEvent StartFloor;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayerWalkStatusEvent()
    {
        StartFloor?.Invoke();
    }
    public void OpenDoorAnimation()
    {
        _animator.SetTrigger("OpenDoor");
    }
    public void CloseDoorAnimation()
    {
        _animator.SetTrigger("CloseDoor");
    }
}
