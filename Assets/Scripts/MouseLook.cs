using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 10f;
    public Transform playerBody;
    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

 
    public void Update()
    {
        float x = sensitivity * Input.GetAxis("Mouse X") * Time.deltaTime;
        float y = sensitivity * Input.GetAxis("Mouse Y") * Time.deltaTime; 

        playerBody.Rotate(Vector3.up * x);

        xRotation -= y;
        xRotation = Mathf.Clamp(xRotation, -71f, 70f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
