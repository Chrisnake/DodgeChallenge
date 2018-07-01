using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class Lives : MonoBehaviour {

    public Text lives;
    public static int score = 0;

	void Start()
	{
        displayLives();
	}
	public void UpdateLives()
    {   
        score = score + 1;
        lives.text = score.ToString();
	}

    public void displayLives()
    {
        lives.text = score.ToString();
    }

    public void resetScore() //Reset the score to 0 after completion of the game
    {
        score = 0;
    }
}
