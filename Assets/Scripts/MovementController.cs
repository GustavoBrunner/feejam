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
    private void Awake()
    {
        components = GetComponent<ComponentController>();
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        components.Controller.Move(speed * Time.deltaTime * move.normalized);
    }
}
