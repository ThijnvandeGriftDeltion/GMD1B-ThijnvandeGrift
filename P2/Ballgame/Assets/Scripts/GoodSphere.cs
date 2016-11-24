using UnityEngine;
using System.Collections;

public class GoodSphere : MonoBehaviour {

	public void OnCollisionEnter (Collision C) {
		if(C.gameObject.name == "Plane") {
			Destroy(gameObject);
		}
	} 
}
