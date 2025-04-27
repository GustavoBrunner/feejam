using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableCloth : MonoBehaviour, IInteractable
{
    public string Name => gameObject.name;

    public void OnInteract()
    {
        GameController.Instance.Events.CurrentFloor.UpdateTaskProgress(1);
    }
}
