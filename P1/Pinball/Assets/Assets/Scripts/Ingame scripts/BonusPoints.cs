using UnityEngine;
using System.Collections;

public class BonusPoints : MonoBehaviour {
	
	public GameObject camera;

	//Adds 10000 points if you hit this object
	public void OnCollisionEnter (Collision collision) {
		Score.getal = Score.getal;
		Score.getal += 10000;
		camera.GetComponent<Score>().score.text = Score.getal.ToString ();
	}
}