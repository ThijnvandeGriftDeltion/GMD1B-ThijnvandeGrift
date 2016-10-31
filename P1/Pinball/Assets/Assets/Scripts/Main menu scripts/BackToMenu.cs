using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {
	
	public GameObject credits;
	
	void Update () {
		Creditsuit();
	}
	
	//Opens the credits
	public void Credits () {
		credits.SetActive(true);
	}
	
	//Closes the credits
	public void Creditsuit () {
		if (Input.GetButtonDown("Jump")) {
			credits.SetActive(false);
		}
		if (Input.GetButtonDown("Escape")) {
			credits.SetActive(false);
		}
	}
}