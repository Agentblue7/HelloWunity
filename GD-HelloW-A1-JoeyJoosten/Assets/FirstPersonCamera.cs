using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Variables
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0;

    bool lockedCursor = true;
    void Start()
    {
        // lock and hide cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;  
    }
    void Update()
    {
        //collect mouse input

        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        //rotate above and below

        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90, 90);
        transform.localEulerAngles=Vector3.right*cameraVerticalRotation;

        //rotate

        player.Rotate(Vector3.up * inputX);
    }
}
