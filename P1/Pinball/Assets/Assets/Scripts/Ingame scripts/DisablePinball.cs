using UnityEngine;
using System.Collections;

public class DisablePinball : MonoBehaviour {
	
	//Disables the launch script
	public void OnTriggerEnter (Collider C) {
		GameObject.Find("Ball2(Clone)").GetComponent<Pinball>().enabled = false;
	}
}