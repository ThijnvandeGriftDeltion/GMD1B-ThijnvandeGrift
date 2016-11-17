using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject menu;
	public GameObject levels;
	public GameObject ingamemenu;
	
	void Start () {
		Time.timeScale = .1f;
	}
	
	void Update () {
		if (Input.GetButtonDown("Escape")) {
			ingamemenu.SetActive(true);
			Time.timeScale = .0001f;
		}
	}
	
	public void LevelEasy () {
		SceneManager.LoadScene("Easy");
		GamemanagerE.lives = GamemanagerE.lives;
		GamemanagerE.lives = 5;
		GamemanagerE.livesplayer2 = GamemanagerE.livesplayer2;
		GamemanagerE.livesplayer2 = 5;
		Time.timeScale = 1;
	}
	
	public void LevelNormal () {
		SceneManager.LoadScene("Normal");
		Gamemanager.lives = Gamemanager.lives;
		Gamemanager.lives = 3;
		Gamemanager.livesplayer2 = Gamemanager.livesplayer2;
		Gamemanager.livesplayer2 = 3;
		Time.timeScale = 1;
	}
	
	public void LevelHardcore () {
		SceneManager.LoadScene("Hardcore");
		GamemanagerHC.lives = GamemanagerHC.lives;
		GamemanagerHC.lives = 1;
		GamemanagerHC.livesplayer2 = GamemanagerHC.livesplayer2;
		GamemanagerHC.livesplayer2 = 1;
		Time.timeScale = 1;
	}
	
	public void StartGame () {
		menu.SetActive(false);
		levels.SetActive(true);
	}
	
	public void Quit () {
		Application.Quit();
	}
	
	public void BackToMenu () {
		levels.SetActive(false);
		menu.SetActive(true);
	}
	
	public void Resume () {
		ingamemenu.SetActive(false);
		Time.timeScale = 1f;
	}
	
	public void ExitToMenu () {
		SceneManager.LoadScene("Menu");
	}
}