using UnityEngine;
using System.Collections;

public class Detection : MonoBehaviour {
	
	private RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			if (Physics.Raycast(transform.position, Vector3.forward, out hit, 10f)) {
				if (hit.transform.tag == "Target") {
				print(hit.transform.name);
			}
		}
	}
}