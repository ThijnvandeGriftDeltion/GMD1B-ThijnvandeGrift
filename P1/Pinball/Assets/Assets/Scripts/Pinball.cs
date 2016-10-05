using UnityEngine;
using System.Collections;

public class Pinball : MonoBehaviour {
	
	public float thrust;
	public Rigidbody pinball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			pinball = GetComponent<Rigidbody>();
			pinball.AddForce(transform.forward * thrust);
		}
	}
}
