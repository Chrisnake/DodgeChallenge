using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float movement = 2000f; //Forward forces 
    public float sideForce = 100f;
    	
	// Update is called once per frame, thus is dependent on the framerate on the computer
    // Fixed update is better for physics related objects
	void FixedUpdate () 
    {
        rb.AddForce(0, 0, movement * Time.deltaTime);
        if(Input.GetKey("d")) //if the user clicks d
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) //if the user clicks d
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1)
        {
            FindObjectOfType<gameManager>().gameOver();
        }
	}

    void OnCollisionEnter(Collision collided)
	{
        if(collided.collider.tag == "Block") //TAGS ARE IMPORTANT AND CAN BE USED ON OBJECTS THAT ARE THE SAME!
        {
            Debug.Log(collided.collider.tag + "Has collided!");
            movement = 0.0f; //After colliding, stop the movement
            sideForce = 0.0f;
            FindObjectOfType<gameManager>().gameOver(); //How to link objects with one another, thus get methods from another object
        }
        if(collided.collider.tag == "End")
        {
            Debug.Log(collided.collider.tag + "Level Complete");
            movement = 0.0f; //After colliding, stop the movement
            sideForce = 0.0f;
        }
	}
}
