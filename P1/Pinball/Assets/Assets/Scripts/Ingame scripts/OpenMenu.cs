using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour {
	
	public GameObject menu;
	public GameObject controls;
	public GameObject play;
	public GameObject colorui;
	public bool menuaan;

	void Update () {
		Menuaan();
		ControlsUit();
	}
	//Opens the menu.
	public void Menuaan () {
		if (Input.GetButtonDown("Escape")) {
			menu.SetActive(true);
			Time.timeScale = 0;
		}
	}
	//Resumes the game.
	public void Resume() {
		menu.SetActive(false);
		Time.timeScale = 1;
	}
	
	//Opens the controls.
	public void Controls() {
		menu.SetActive(false);
		controls.SetActive(true);
	}
	//Closes the controls.
	public void ControlsUit() {
		if (Input.GetButtonDown("Escape")) {
			controls.SetActive(false);
			menu.SetActive(true);
		}
	}
	//Goes back to the main menu.
	public void LoadScene() {
		SceneManager.LoadScene ("Menu");
	}
	//Exit the game.
	public void ExitGame() {
		Application.Quit();
	}
	
	//Starts the game
	public void StartGame () {
		play.SetActive(false);
		colorui.SetActive(false);
		GameObject.Find("FlipperLinks").GetComponent<RotatorLinks>().enabled = true;
		GameObject.Find("FlipperRechts").GetComponent<RotatorRechts>().enabled = true;
		GameObject.Find("Spawnlocation pinball").GetComponent<NewBall>().enabled = true;
	}
}