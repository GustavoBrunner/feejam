using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switcher : MonoBehaviour, IInteractable
{
    private Collider collider;
    public UnityEvent InteractEvent;
    public string Name => "Switcher";

    private void Awake()
    {
        collider.enabled = false;
    }

    public void SetEnabled(bool enable)
    {
        collider.enabled = enable;
    }


    public void OnInteract()
    {
        InteractEvent?.Invoke();
    }

}
