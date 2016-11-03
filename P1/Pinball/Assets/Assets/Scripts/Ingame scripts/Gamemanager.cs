using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour {


	public static int lives = 3;
	public GameObject gameover;
	public Text livesdisplay;
	
	void Update () {
		DisplayLives();
		GameOver();
	}
	
	//When you're out of lives it opens a panel
	public void GameOver () {
		if (lives ==  0) {
			gameover.SetActive(true);
		}
	}
	
	//Loads the menu
	public void BackToMenu (int level) {
		SceneManager.LoadScene ("Menu");
	}
	
	//Shows how many lives you have on the scoreboard
	public void DisplayLives () {
	livesdisplay.text = lives.ToString ();
	}
}