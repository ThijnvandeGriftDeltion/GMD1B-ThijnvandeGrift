using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour {
	
	public GameObject panel;
	public GameObject body;
	public GameObject camera;
	
	void Start () {
		body = GameObject.Find("Player");
		camera = GameObject.Find("Main Camera");
	}
	
	//Pauses the game when you press the Escape button.
	void Update () {
		if (Input.GetButtonDown("Escape")) {
			panel.SetActive(true);
			Time.timeScale = .00001f;
			body.GetComponent<FirstPerson>().enabled = false;
			camera.GetComponent<GrenadeLauncher>().enabled = false;
			Cursor.visible = true;
		}
	}
	
	///Resumes the game when you press the button.
	public void Resume() {
		panel.SetActive(false);
		Time.timeScale = 1;
		body.GetComponent<FirstPerson>().enabled = true;
		camera.GetComponent<GrenadeLauncher>().enabled = true;
		Cursor.visible = false;
	}
	
	//Exit the entire game.
	public void QuitToWindows() {
		Application.Quit();
	}
}
