using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {
	
	public Canvas menu;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Back ();
		CanvasUit ();
	}
	
	public void Back () {
		if(Input.GetButtonDown ("Jump")) {
			menu.enabled = true;
		}
	}
	
	public void CanvasUit () {
		menu.enabled = false;
	}
}
