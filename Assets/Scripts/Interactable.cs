using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour, IInteractable
{
    public string Name => gameObject.name;

    

    void IInteractable.OnInteract()
    {
        Debug.Log("Interacted");
    }
}
