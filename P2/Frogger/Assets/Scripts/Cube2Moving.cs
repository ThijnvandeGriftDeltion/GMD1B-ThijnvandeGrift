using UnityEngine;
using System.Collections;

public class Cube2Moving : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(-1,0,0) * Time.deltaTime);
	}
	
	public void OnCollisionEnter (Collision C) {
		if(C.gameObject.tag == ("Deathzone")) {
			Destroy(gameObject);
		}
	}
}