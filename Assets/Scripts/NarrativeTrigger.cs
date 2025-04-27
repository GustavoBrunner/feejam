using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NarrativeTrigger : MonoBehaviour
{
    public UnityEvent TriggerEvent;
    private BoxCollider collider;

    public void SetCollider(bool status)
    {
        collider.enabled = status;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<MovementController>() != null)
            TriggerEvent?.Invoke();
    }
}
