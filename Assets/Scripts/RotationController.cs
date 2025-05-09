using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;


public class RotationController : MonoBehaviour
{
    public float mouseSensitivity = 2f;
    public Transform playerBody;

    float xRotation = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
