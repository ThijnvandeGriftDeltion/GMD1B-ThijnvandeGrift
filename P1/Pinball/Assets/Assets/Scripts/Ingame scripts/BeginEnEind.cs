using UnityEngine;
using System.Collections;

public class BeginEnEind : MonoBehaviour {

	public void OnCollisionEnter (Collision C) {
		Destroy(C.gameObject);
		GameObject.Find("Database").GetComponent<Gamemanager>().lives -= 1;
	}
	
	public void OnTriggerExit (Collider other) {
		GameObject.Find("Pinball").GetComponent<Pinball>().enabled = false;
	}
}
