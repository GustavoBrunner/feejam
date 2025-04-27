using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ComponentController))]
public class MovementController : MonoBehaviour
{
    [SerializeField]
    private ComponentController components;

    [SerializeField]
    private float speed;

    [SerializeField]
    private bool isPushing;

    [SerializeField]
    private bool canWalk = false;

    private void Awake()
    {
        components = GetComponent<ComponentController>();
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        if (!canWalk) return;
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        components.Controller.Move(speed * Time.deltaTime * move.normalized);
    }

    public void SetCanRun(bool value)
    {
        canWalk = value;
    }
}
