using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishManager : MonoBehaviour {

	// Use this for initialization
	public void goMenu()
    {
        FindObjectOfType<Lives>().resetScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }
}
