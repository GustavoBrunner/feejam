using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [field: SerializeField]
    public bool isOpen { get; private set; } = false;

    public string Name => gameObject.name;

    [SerializeField]
    private Animator animator;


    public void OpenDoor()
    {
        isOpen = true;
    }

    public void OnInteract()
    {
        throw new System.NotImplementedException();
    }
}
