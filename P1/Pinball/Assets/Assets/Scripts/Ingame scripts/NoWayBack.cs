using UnityEngine;
using System.Collections;

public class NoWayBack : MonoBehaviour {

	public GameObject stop;
	
	public void OnTriggerEnter (Collider C) {
		stop.GetComponent<MeshRenderer>().enabled = true;
	}
}
