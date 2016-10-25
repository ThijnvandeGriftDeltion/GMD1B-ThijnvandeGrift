using UnityEngine;
using System.Collections;

public class BumperForce : MonoBehaviour {

	public float thrust;
	public Rigidbody pinball;
	public GameObject ball;
	
	void Start () {
		pinball = ball.GetComponent<Rigidbody>();
	}
	
	public void OnCollisionEnter (Collision collision) {
		pinball.AddForce(5,5,5 * thrust);
	}
}
