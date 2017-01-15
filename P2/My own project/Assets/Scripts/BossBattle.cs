using UnityEngine;
using System.Collections;

public class BossBattle : MonoBehaviour {
	
	public float timer;
	public GameObject lights;
	public GameObject lights2;
	public GameObject lights3;
	public GameObject bosslights;
	public bool entered;
	public GameObject boss;
	public GameObject guideLight;
	public GameObject door;
	public bool dead;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (entered == true) {
			timer -= Time.deltaTime;
			if (timer <= 5) {
				lights.SetActive (true);
			}
			if (timer <= 3) {
				lights2.SetActive (true);
			}
			if (timer <= 0) {
				lights3.SetActive (true);
				bosslights.SetActive (true);
			}
			if (timer <= -1) {
				GameObject.Find("Boss").GetComponent<Boss>().enabled = true;
			}
		}
		if (entered == false) {
			boss.transform.position = (new Vector3(25,1,-7.5f));
			boss.GetComponent<Boss>().bosshp = 20;
		}
		if (boss.GetComponent<Boss>().bosshp == 20) {
			boss.GetComponent<Boss>().movespeed = 5;
		}
		if (boss.GetComponent<Boss>().bosshp <= 0) {
			guideLight.SetActive (true);
			entered = false;
		}
	}
	
	public void OnTriggerEnter (Collider C) {
		if (C.transform.tag == "Player" && entered == false) {
			entered = true;
		}
		else if (C.transform.tag == "Player" && entered == true) {
			entered = false;
		}
	}
}