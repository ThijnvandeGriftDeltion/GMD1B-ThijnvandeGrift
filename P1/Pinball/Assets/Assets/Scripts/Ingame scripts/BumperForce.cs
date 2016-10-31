using UnityEngine;
using System.Collections;

public class BumperForce : MonoBehaviour {

	public Rigidbody pinball;
	public Vector3 v;
	
	//Gives the pinball a force so that it "bounces" off
	public void OnCollisionEnter (Collision collision) {
		GameObject.Find("Ball(Clone)").GetComponent<Rigidbody>().AddForce(v);
	}
}
