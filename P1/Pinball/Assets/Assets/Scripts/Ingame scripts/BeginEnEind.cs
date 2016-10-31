using UnityEngine;
using System.Collections;

public class BeginEnEind : MonoBehaviour {
	
	//Destroys the pinball and removes a life
	public void OnCollisionEnter (Collision C) {
		Destroy(C.gameObject);
		GameObject.Find("Database").GetComponent<Gamemanager>().lives -= 1;
		GameObject.Find("Spawnlocation pinball").GetComponent<NewBall>().enabled = true;
	}
	
	//Enables the Pinball script
	public void OnTriggerExit (Collider other) {
		GameObject.Find("Pinball").GetComponent<Pinball>().enabled = false;
	}
}
