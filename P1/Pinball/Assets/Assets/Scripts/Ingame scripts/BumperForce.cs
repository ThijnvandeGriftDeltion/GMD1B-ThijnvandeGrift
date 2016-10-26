using UnityEngine;
using System.Collections;

public class BumperForce : MonoBehaviour {

	public Rigidbody pinball;
	public Vector3 v;
	
	public void OnCollisionEnter (Collision collision) {
		pinball.AddForce(v);
	}
}
