﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour {
	
	public GameObject panel;
	public GameObject body;
	public GameObject camera;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Escape")) {
			panel.SetActive(true);
			Time.timeScale = .00001f;
			body.GetComponent<FirstPerson>().enabled = false;
			camera.GetComponent<Detection>().enabled = false;
			Cursor.visible = true;
		}
	}
	
	public void Resume() {
		panel.SetActive(false);
		Time.timeScale = 1;
		body.GetComponent<FirstPerson>().enabled = true;
		camera.GetComponent<Detection>().enabled = true;
		Cursor.visible = false;
	}
	
	public void QuitToWindows() {
		Application.Quit();
	}
	
	public void Restart() {
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
		Time.timeScale = 1;
	}
}
