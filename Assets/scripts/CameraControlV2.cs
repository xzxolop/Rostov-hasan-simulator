using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlV2 : MonoBehaviour
{
    private float xRotation;
    private float yRotation;
    public Transform orentation;
    public float sensX;
    public float sensY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

     void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -80f, 60f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orentation.rotation = Quaternion.Euler(0, yRotation, 0);

    }
}
