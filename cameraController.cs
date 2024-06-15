using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform playertransform;
    public float mouseSensivity = 200f;
    private float xRotation;
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseXpos = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseYpos = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseYpos; 
        xRotation = Mathf.Clamp(xRotation, -60f, 60f);
        this.gameObject.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        playertransform.Rotate(Vector3.up*mouseXpos);

    }
}
