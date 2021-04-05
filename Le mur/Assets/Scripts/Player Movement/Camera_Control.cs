using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    //Mouse Sencitivity option, so we could change it in settings
    public float mouseSencitivity = 100f;

    //The public access to the player object, so we can setup and change it without opening code
    public Transform playerBody;

    //Saving the current camera rotation, so the camera won't get back after every "Update"
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Locking the coursor visibility and position so it won't run outside the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Reading and saving the changes of mouse position.
        // It's also aplies mouseSencitivity
        // The time.deltaTime is counting the time between every Update() calls
        float mouseX = Input.GetAxis("Mouse X") * mouseSencitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSencitivity * Time.deltaTime;

        //Setting up the rotation of Y axis
        xRotation -= mouseY;
        //Lock the rotation between -90 degree and 90 degree, so camera won't pass all the way of y axis 
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Rotate the object, this code assigned to it
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotate the object intered into playerBody
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
