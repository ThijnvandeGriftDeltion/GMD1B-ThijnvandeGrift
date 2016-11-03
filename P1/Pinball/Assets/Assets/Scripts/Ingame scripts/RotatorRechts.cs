using UnityEngine;
using System.Collections;

public class RotatorRechts : MonoBehaviour {

	public float flipperStrength;
	public float pushForce;

	// Update is called once per frame
	// Rotates the right flipper by using a hinge joint
	void FixedUpdate () {
		if(Input.GetButtonDown("E")) {
			Vector3 f = transform.up * flipperStrength;
			Vector3 p = (transform.right) + transform.position * pushForce;
			GetComponent<Rigidbody>().AddForceAtPosition(f, p);
		}
	}
}
