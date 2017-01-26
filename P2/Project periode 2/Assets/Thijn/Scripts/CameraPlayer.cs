using UnityEngine;
using System.Collections;

public class CameraPlayer : MonoBehaviour {
	
	public GameObject elevator;
	public RaycastHit hit;

	// Update is called once per frame
	void Update () {
		RaycastUse ();
	}

	//A use button for doors and elevators.
	public void RaycastUse () {
		if (Physics.Raycast(transform.position, transform.forward, out hit, 2)) {
			if (Input.GetButtonDown("E")) {
				if (hit.transform.tag == "Door" && hit.transform.gameObject.GetComponent<Door>().dooropen == false) {
					hit.transform.Rotate(new Vector3(0, 90, 0));
					hit.transform.gameObject.GetComponent<Door>().dooropen = true;
				}
				if (hit.transform.tag == "Door" && hit.transform.gameObject.GetComponent<Door>().dooropen == true) {
					hit.transform.Rotate(new Vector3(0, -90, 0));
					hit.transform.gameObject.GetComponent<Door>().dooropen = false;
				}
				if (hit.transform.tag == "ElevatorButton1") {
					elevator.GetComponent<SuperButton>().state = SuperButton.State.Een;
				}
				if (hit.transform.tag == "ElevatorButton2") {
					elevator.GetComponent<SuperButton>().state = SuperButton.State.Twee;
				}
			}
		}
	}
}