using UnityEngine;
using System.Collections;

public class NegativePoints : MonoBehaviour {
	
	public GameObject camera;

	//Adds 10000 points if you hit this object
	public void OnCollisionEnter (Collision collision) {
		Score.getal = Score.getal;
		Score.getal -= 1000;
		camera.GetComponent<Score>().score.text = Score.getal.ToString ();
	}
}