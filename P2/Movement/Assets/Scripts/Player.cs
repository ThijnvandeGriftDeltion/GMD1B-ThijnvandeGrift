using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public Vector3 a;
	public float hor;
	public GameObject database;
	public Rigidbody player2;
	public float jumppower = 500;
	public bool grounded = true;
	public float timer = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		hor = Input.GetAxis("Horizontal");
		a.x = hor;
		transform.Translate(a * Time.deltaTime * 10);
		timer -= Time.deltaTime;
		if(!grounded && timer <= 0) {
        grounded = true;
		timer = 2;
		}
	}
	
	public void FixedUpdate () {
		if (Input.GetButtonDown("Up") && grounded == true) {
            player2.AddForce(transform.up*jumppower);
            grounded = false;
		}
    }
	
	public void OnCollisionEnter (Collision C) {
		if (C.gameObject.name == "Sphere(Clone)") {
			Gamemanager.livesplayer2 = Gamemanager.livesplayer2;
			Gamemanager.livesplayer2 -= 1;
			Destroy(C.gameObject);
		}
		else if (C.gameObject.name == "GoodSphere(Clone)") {
			Gamemanager.livesplayer2 = Gamemanager.livesplayer2;
			Gamemanager.livesplayer2 += 1;
			Destroy(C.gameObject);
		}
	}
}