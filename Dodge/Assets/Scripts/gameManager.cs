using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    public GameObject completeLevelUI;
    bool gameEnded = false;

    public void gameOver()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Invoke("restart", 2f);
            FindObjectOfType<Lives>().UpdateLives();
        }
    }

    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //For restarting the game! 
    }

}
