using UnityEngine;
using System.Collections;

public class BumperForce : MonoBehaviour {

	public Vector3 v;
	
	//Gives the pinball a force so that it "bounces" off
	public void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Ball") {
			GameObject.Find("Ball(Clone)").GetComponent<Rigidbody>().AddForce(v);
		}
		else if (col.gameObject.tag == "Ball2") {
			GameObject.Find("Ball2(Clone)").GetComponent<Rigidbody>().AddForce(v);
		}
		else if (col.gameObject.tag == "BonusBall") {
			GameObject.Find("BonusBall(Clone)").GetComponent<Rigidbody>().AddForce(v);
		}
		else if (col.gameObject.tag == "BonusBall2") {
			GameObject.Find("BonusBall2(Clone)").GetComponent<Rigidbody>().AddForce(v);
		}
	}
}
