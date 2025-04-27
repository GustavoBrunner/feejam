using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour, IInteractable
{
    public string Name => "Trash";

    public void OnInteract()
    {
        this.gameObject.SetActive(false);
        GameController.Instance.Events.CurrentFloor.UpdateTaskProgress();
    }
}
