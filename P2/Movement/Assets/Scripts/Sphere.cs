using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {

	public void OnCollisionEnter (Collision C) {
		if(C.gameObject.name == "Plane")
		Destroy(gameObject);
	}
}