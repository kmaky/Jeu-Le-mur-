using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    //connect RigidBody from player.
    private Rigidbody rb;

    //The public speed might be changed from settimgs
    public float speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        // setup for RigidBody component
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //get imputs from two axis, vertical and horizontal.
        // the vertival assigned to axe z because we want it to move that way
        float x = Input.GetAxisRaw("Horizontal") * speed;
        float z = Input.GetAxisRaw("Vertical") * speed;

        //initiate the Vector and set it to changes in two directions
        Vector3 movePos = transform.right * x + transform.forward * z;

        //Add gravity thing to my vector
        Vector3 move = new Vector3(movePos.x, rb.velocity.y, movePos.z);

        // Move the object to Vector3 object
        rb.velocity = move;
    }
}
