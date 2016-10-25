using UnityEngine;
using System.Collections;

public class OpenMenu : MonoBehaviour {
	
	public GameObject menu;
	public GameObject controls;
	public bool menuaan;

	void Update () {
		Menuaan();
		ControlsUit();
	}
	//Opens the menu.
	public void Menuaan () {
		if (Input.GetButtonDown("Escape")) {
			menu.SetActive(true);
		}
	}
	//Resumes the game.
	public void Resume() {
		menu.SetActive(false);
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
	public void LoadScene(int level) {
		Application.LoadLevel(level);
	}
	//Exit the game.
	public void ExitGame() {
		Application.Quit();
	}
}