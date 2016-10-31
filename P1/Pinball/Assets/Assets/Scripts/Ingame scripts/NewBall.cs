using UnityEngine;
using System.Collections;

public class NewBall : MonoBehaviour {
	
	public GameObject prefab;
	public GameObject spawnlocation;
	
	void Update () {
		RespawnBall();
	}
	
	//Spawns a new ball
	public void RespawnBall () {
		if (Input.GetButtonDown("R")) {
			Instantiate(prefab, spawnlocation.GetComponent<Transform>().position, spawnlocation.GetComponent<Transform>().rotation);
		}
	}
}
