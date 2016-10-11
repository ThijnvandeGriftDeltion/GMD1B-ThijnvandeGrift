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
	
	public void Menuaan () {
		if (Input.GetButtonDown("Escape")) {
			menu.SetActive(true);
		}
	}

	public void Resume() {
		menu.SetActive(false);
	}
		
	public void Controls() {
		menu.SetActive(false);
		controls.SetActive(true);
	}
	
	public void ControlsUit() {
		if (Input.GetButtonDown("Escape")) {
			controls.SetActive(false);
			menu.SetActive(true);
		}
	}
	
	public void LoadScene(int level) {
		Application.LoadLevel(level);
	}
	
	public void ExitGame() {
		Application.Quit();
	}
}