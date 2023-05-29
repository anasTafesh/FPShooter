using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    //  public Transform weaponParent;
    public GameObject cam;
    private float xRotation = 0f;
    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }
    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);                                                           // Apply damping to smooth out weapon rotation on the X-axis
    }


}