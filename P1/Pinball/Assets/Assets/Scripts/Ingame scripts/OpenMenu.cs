using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour {
	
	public GameObject menu;
	public GameObject controls;
	public GameObject play;
	public GameObject colorui;
	public GameObject colorui2;
	public bool menuaan;

	void Update () {
		Menuaan();
		ControlsUit();
	}
	//Opens the menu.
	public void Menuaan () {
		if (Input.GetButtonDown("Escape") && menuaan == false) {
			menu.SetActive(true);
			menuaan = true;
		}
	}
	//Resumes the game.
	public void Resume() {
		menu.SetActive(false);
	}
	
	public void ResumeByButton() {
		if (Input.GetButtonDown("Escape") && menuaan == true) {
			menu.SetActive(false);
			menuaan = false;
		}
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
		colorui2.SetActive(false);
		GameObject.Find("Pinball").GetComponent<Pinball>().enabled = true;
		GameObject.Find("FlipperLinks").GetComponent<RotatorLinks>().enabled = true;
		GameObject.Find("FlipperRechts").GetComponent<RotatorRechts>().enabled = true;
	}
}