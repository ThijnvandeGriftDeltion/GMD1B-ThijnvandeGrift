using UnityEngine;
using System.Collections;

public class Pinball : MonoBehaviour {

	public float thrust;
	public Rigidbody pinball;
	
	// Update is called once per frame
	void Update () {
		StartGame();
	}
	
	//Launches the ball at the start of the game when you press the spacebar
	public void StartGame() {
		if (Input.GetButtonDown ("Jump")) {
			pinball = GetComponent<Rigidbody>();
			pinball.AddForce(transform.forward * thrust);
		}
	}
}