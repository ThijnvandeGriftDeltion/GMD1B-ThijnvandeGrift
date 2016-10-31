using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	static int getal;
	public Text score;

	// Use this for initialization
	void Start () {
		getal = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnCollisionEnter (Collision collision) {
		getal = getal + 1;
		score.text = getal.ToString ();
	}
}