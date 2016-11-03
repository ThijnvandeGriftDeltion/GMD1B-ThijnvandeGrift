using UnityEngine;
using System.Collections;

public class NoWayBack : MonoBehaviour {

	public GameObject prefab;
	public GameObject spawnlocation;
	
	//Spawns a collider to prevent the ball from rolling back to the spawn area
	public void OnTriggerEnter (Collider C) {
		Instantiate(prefab, spawnlocation.GetComponent<Transform>().position, spawnlocation.GetComponent<Transform>().rotation);
	}
}
