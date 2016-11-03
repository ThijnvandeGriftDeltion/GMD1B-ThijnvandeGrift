using UnityEngine;
using System.Collections;

public class BonusPoints : MonoBehaviour {

	//Adds 10 points if you hit this object
	public void OnCollisionEnter (Collision collision) {
		Score.getal = Score.getal;
		Score.getal += 10;
		GameObject.Find("Main Camera").GetComponent<Score>().score.text = Score.getal.ToString ();
	}
}
