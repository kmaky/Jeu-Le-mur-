using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    //connect Player Movement from player.
    //I made it public so it would be more easy to connect it
    public CharacterController controller;

    //The public speed might be changed from settimgs
    public float speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //get imputs from two axis, vertical and horizontal.
        // the vertival assigned to axe z because we want it to move that way
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //initiate the Vector and set it to changes in two directions
        Vector3 move = transform.right * x + transform.forward * z;

        // Move the object to Vector3 object
        controller.Move(move * speed * Time.deltaTime);
    }
}
