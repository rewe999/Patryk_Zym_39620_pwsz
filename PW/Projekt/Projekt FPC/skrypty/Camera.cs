using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float defaulmoseSens;
    public float mouseSensitivity = 100f;

    public Transform player;

    float xRotation = 0f;


    private void Start()
    {
        defaulmoseSens = mouseSensitivity;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }


    public float getSens()
    {
        return defaulmoseSens;
    }

    public void setSens(float val)
    {
        mouseSensitivity = val;
    }
}
