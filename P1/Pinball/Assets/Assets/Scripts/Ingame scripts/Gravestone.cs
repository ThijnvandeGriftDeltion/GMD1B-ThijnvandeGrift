using UnityEngine;
using System.Collections;

public class Gravestone : MonoBehaviour {
	
	public GameObject camera;
	public GameObject grave;

	public void OnCollisionEnter (Collision collision) {
		Destroy(grave);
		Score.getal = Score.getal;
		Score.getal += 20000;
		camera.GetComponent<Score>().score.text = Score.getal.ToString ();
	}
}