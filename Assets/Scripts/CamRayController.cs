using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRayController : MonoBehaviour
{
    public float interactionDistance = 3f;
    
    public Camera playerCamera;

    [SerializeField]
    private IInteractable currentInteractable;

    private void Update()
    {
        DetectInteractable();
        HandleInteraction();
    }

    private void DetectInteractable()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.forward * interactionDistance, Color.magenta,.5f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, interactionDistance))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            if (interactable != null)
            {
                if (currentInteractable != interactable)
                {
                    currentInteractable = interactable;
                    Debug.Log("Apontando para: " + currentInteractable.Name);
                }
            }
        }
        else
        {
            if (currentInteractable != null)
            {
                currentInteractable = null;
                Debug.Log("Não está apontando para nada interativo");
            }
        }
    }

    private void HandleInteraction()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            currentInteractable.OnInteract();
        }
    }
}
