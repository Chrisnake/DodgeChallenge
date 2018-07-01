using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

    public Transform player; //Gets the reference of the transform values of an object. 
    public Vector3 offset; //Offset that updates to follow the player
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.position = player.position + offset;
	}
}
