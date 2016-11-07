using UnityEngine;
using System.Collections;

public class BeginEnEind : MonoBehaviour {
	
	public GameObject bonus;
	
	//Enables the Pinball script
	void Start () {
		GameObject.Find("Ball(Clone)").GetComponent<Pinball>().enabled = true;
	}
	
	//Destroys the pinball and removes a life
	public void OnCollisionEnter (Collision C) {
		Destroy(C.gameObject);
		if (C.gameObject.tag == "Ball2") {
			Gamemanager.lives = Gamemanager.lives;
			Gamemanager.lives -= 1;
			GameObject.Find("Spawnlocation pinball").GetComponent<NewBall>().enabled = true;
			Destroy(GameObject.Find("Stop(Clone)"));
			Destroy(GameObject.Find("BonusBall2(Clone)"));
			bonus.GetComponent<BonusBall>().spawned = false;
		}
		else if (C.gameObject.tag == "BonusBall2") {
			bonus.GetComponent<BonusBall>().spawned = false;
		}
		else if (C.gameObject.tag == "Ball") {
			Gamemanager.lives = Gamemanager.lives;
			Gamemanager.lives -= 1;
			GameObject.Find("Spawnlocation pinball").GetComponent<NewBall>().enabled = true;
			Destroy(GameObject.Find("Stop(Clone)"));
			Destroy(GameObject.Find("BonusBall(Clone)"));
			bonus.GetComponent<BonusBall>().spawned = false;
		}
			else if (C.gameObject.tag == "BonusBall") {
			bonus.GetComponent<BonusBall>().spawned = false;
		}
	}
}
