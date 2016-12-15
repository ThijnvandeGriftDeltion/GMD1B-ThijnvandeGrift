using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour {
	
	private int force = 30000;
	public Rigidbody grenade;
	public bool shot;
	public float radius = 5;
	public GameObject boss;

	// Use this for initialization
	void Start () {
		grenade = GetComponent<Rigidbody>();
		shot = false;		
	}
	
	// Update is called once per frame
	void Update () {
		if (shot == false) {
			grenade.AddForce(GameObject.Find("Main Camera").transform.forward * force);
			shot = true;
		}
	}
	
	public void OnCollisionEnter (Collision C) {
		if (C.transform.tag == "Enemy") {
			Detection.shotsHit = Detection.shotsHit + 1;
			Detection.points = Detection.points + 1;
			Destroy(C.transform.gameObject);
			Gamemanager.enemies -= 1;
		}
		else if (C.transform.tag == "Head") {
			Detection.shotsHit = Detection.shotsHit + 1;
			Detection.headshot = Detection.headshot + 1;
			Detection.points = Detection.points + 10;
			Destroy(C.transform.parent.gameObject);
			Gamemanager.enemies = Gamemanager.enemies;
			Gamemanager.enemies -= 1;
		}
		if (C.transform.tag == "Boss") {
			Detection.shotsHit = Detection.shotsHit + 1;
			Detection.headshot = Detection.headshot + 1;
			Detection.points = Detection.points + 10;
			GameObject.Find("Boss").GetComponent<Boss>().bosshp -= 1;
		}
		Destroy(gameObject);
	}
}