using UnityEngine;
using System.Collections;

public class DisableSpawning : MonoBehaviour {

	//Disables the script that spawns a new ball
	public void OnTriggerEnter (Collider C) {
				GameObject.Find("Spawnlocation pinball").GetComponent<NewBall>().enabled = false;
	}
}