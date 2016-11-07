using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

    public GameObject loadingImage;
	public GameObject levels;
	
	//Puts up a loading image while loading a different scene
    public void Level1() {
        loadingImage.SetActive(true);
        SceneManager.LoadScene ("Pinball");
		Time.timeScale = 1;
		Gamemanager.lives = 3;
    }
	
	//Puts up a loading image while loading a different scene
	public void Level2() {
        loadingImage.SetActive(true);
        SceneManager.LoadScene ("Pinball2");
		Time.timeScale = 1;
		Gamemanager.lives = 3;
    }
	
	public void ChooseLevel() {
		levels.SetActive(true);
	}
	
	public void Back() {
		if (Input.GetButtonDown("Escape")) {
			levels.SetActive(false);
		}
	}
}