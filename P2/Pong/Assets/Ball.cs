using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public Rigidbody ball;
	public float force;

	// Use this for initialization
	void Start () {
		ball = GetComponent<Rigidbody>();
		ball.AddForce(transform.forward * force);
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void OnCollisionEnter (Collision C) {
		//ball.AddForce(transform.forward * force);
	}
}
