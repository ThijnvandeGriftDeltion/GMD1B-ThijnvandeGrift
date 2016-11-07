using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int getal;
	public Text score;
	public ParticleSystem particles;
	public bool extra;

	// Use this for initialization
	void Start () {
		getal = 0;
	}
	
	// Update is called once per frame
	void Update () {
		ExtraLife();
	}
	
	//Adds 1 point to the score
	public void OnCollisionEnter (Collision collision) {
		particles.Play();
		getal = getal + 1000;
		score.text = getal.ToString ();
	}
	
	//Gives the player an extra life if he reaches a score of 100
	public void ExtraLife () {
		if ((getal >= 200000) && (extra == false)) {
			extra = true;
			Gamemanager.lives = Gamemanager.lives;
			Gamemanager.lives += 1;
		}
	}
}