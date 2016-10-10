using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {
	
	public GameObject credits;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Credits () {
		credits.SetActive(true);
	}
	
	public void Creditsuit () {
		if (Input.GetButtonDown("jump")) {
			credits.SetActive(false);
		}
	}
}