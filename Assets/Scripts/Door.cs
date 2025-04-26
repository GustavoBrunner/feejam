using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [field: SerializeField]
    public bool isOpen { get; private set; } = false;


    public void OpenDoor()
    {
        isOpen = true;
    }
}
