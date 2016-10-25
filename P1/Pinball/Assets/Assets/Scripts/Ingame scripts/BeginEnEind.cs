using UnityEngine;
using System.Collections;

public class BeginEnEind : MonoBehaviour {
	
	public GameObject otherObject;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		OnTriggerEnter();
	}
	
	public void OnTriggerEnter () {
		Destroy(gameObject);
	}
	
	public void OnTriggerExit () {
		 otherObject.GetComponent<Pinball>().enabled = false;
	}
}
