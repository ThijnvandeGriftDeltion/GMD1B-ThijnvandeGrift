using UnityEngine;
using System.Collections;

public class CameraPlayer : MonoBehaviour {
	
	public GameObject elevator;
	public RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("E")) {
			if (Physics.Raycast(transform.position, transform.forward, out hit, 2)) {
				if (hit.transform.tag == "ElevatorButton1") {
					elevator.GetComponent<SuperButton>().state = SuperButton.State.Een;
				}
				if (hit.transform.tag == "ElevatorButton2") {
					elevator.GetComponent<SuperButton>().state = SuperButton.State.Twee;
				}
				if (hit.transform.tag == "ElevatorButton3") {
					elevator.GetComponent<SuperButton>().state = SuperButton.State.Drie;
				}
			}
		}
	}
}