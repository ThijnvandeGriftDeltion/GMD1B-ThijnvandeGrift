using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {
	
	public GameObject credits;
	
	void Update () {
		Creditsuit();
	}
	
	public void Credits () {
		credits.SetActive(true);
	}
	
	public void Creditsuit () {
		if (Input.GetButtonDown("Jump")) {
			credits.SetActive(false);
		}
	}
}