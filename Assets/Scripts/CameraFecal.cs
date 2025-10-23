using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFecal : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Adjust this for sensitivity

    public Transform playerBody; // Assign your player GameObject's Transform here

    float xRotation = 5.0f;

    void Start()
    {
        // Lock the cursor to the center of the screen and hide it
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Vertical camera rotation (looking up and down)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Clamp rotation to prevent flipping

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Horizontal player rotation (turning left and right)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}