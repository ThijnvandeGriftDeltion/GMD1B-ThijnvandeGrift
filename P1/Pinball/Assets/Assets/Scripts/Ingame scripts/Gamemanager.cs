using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour {


	public int lives = 3;
	public GameObject gameover;
	public Text livesdisplay;
	public Vector3 spawnspot = new Vector3 (-589.6f, -55, -144.4f);
	public GameObject pinball;
	public GameObject collider;
	
	void Update () {
		DisplayLives();
	}
	
	public void GameOver () {
		if (lives ==  0) {
			gameover.SetActive(true);
		}
	}
	
	public void BackToMenu (int level) {
		Application.LoadLevel(level);
	}
	
	public void DisplayLives () {
	livesdisplay.text = lives.ToString ();
	}
	
	public void RespawnBall () {
		if (Input.GetButtonDown("R")) {
			GameObject Pinball = (GameObject)Instantiate(pinball, spawnspot, Quaternion.identity);
		}
	}
}
