using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController), typeof(Rigidbody), typeof(Collider))]
public class ComponentController : MonoBehaviour
{
    public CharacterController Controller { get; private set; }
    public Rigidbody Rb { get; private set; }
    public Collider Clldr { get; private set; }

    private void Awake()
    {
        Controller = GetComponent<CharacterController>();
        Rb = GetComponent<Rigidbody>();
        Clldr = GetComponent<Collider>();
    }
}
