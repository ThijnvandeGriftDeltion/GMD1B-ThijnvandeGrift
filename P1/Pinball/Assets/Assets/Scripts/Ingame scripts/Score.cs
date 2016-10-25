using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int getal;
	public Text score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Hit () {
		getal = getal + 1;
		score.text = "Getal: " + getal.ToString ();
	}
}