using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour {
    
    public gameManager GameManager;

    public void OnTriggerEnter(Collider other) //When the player has triggered the winning object
	{
        GameManager.completeLevel();
	}
}
