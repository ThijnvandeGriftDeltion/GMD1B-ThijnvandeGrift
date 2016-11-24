using UnityEngine;
using System.Collections;

public class MovingHC : MonoBehaviour {
	
	public Vector3 a;
	public float hor;
	public GameObject database;
	public Rigidbody player;
	public float jumppower = 500;
	public bool grounded = true;
	public float timer = 1;

	// Update is called once per frame
	void Update () {
		hor = Input.GetAxis("Horizontal1");
		a.x = hor;
		transform.Translate(a * Time.deltaTime * 10);
		timer -= Time.deltaTime;
		if(!grounded && timer <= 0) {
        grounded = true;
		timer = 1;
		}	
	}
	
	public void FixedUpdate () {
		if (Input.GetButtonDown("W") && grounded == true) {
            player.AddForce(transform.up*jumppower);
            grounded = false;
        }
	}
	
	public void OnCollisionEnter (Collision C) {
		if (C.gameObject.name == "Sphere(Clone)") {
			GamemanagerHC.lives = GamemanagerHC.lives;
			GamemanagerHC.lives -= 1;
			Destroy(C.gameObject);
		}
		else if (C.gameObject.name == "GoodSphere(Clone)") {
			GamemanagerHC.lives = GamemanagerHC.lives;
			GamemanagerHC.lives += 1;
			Destroy(C.gameObject);
		}
	}
}
