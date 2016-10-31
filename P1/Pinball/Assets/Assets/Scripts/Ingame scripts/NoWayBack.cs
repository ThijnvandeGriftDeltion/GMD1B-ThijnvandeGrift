using UnityEngine;
using System.Collections;

public class NoWayBack : MonoBehaviour {

	public GameObject prefab;
	public GameObject spawnlocation;
	
	public void OnTriggerEnter (Collider C) {
		Instantiate(prefab, spawnlocation.GetComponent<Transform>().position, spawnlocation.GetComponent<Transform>().rotation);
	}
}
