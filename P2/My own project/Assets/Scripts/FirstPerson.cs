using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FirstPerson : MonoBehaviour {
	
	public Vector3 move;
	public Vector3 move2;
	public GameObject hoofd;
	public Vector3 a;
	public float hor;
	public float ver;
	public Rigidbody player;
	public float jumppower = 200;
	public int health = 20;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Restart();
		move2.y = Input.GetAxis("Mouse X");
		transform.Rotate(move2);
		move.x = -Input.GetAxis("Mouse Y");
		hoofd.transform.Rotate(move);
		hor = Input.GetAxis("Horizontal");
		a.x = hor;
		ver = Input.GetAxis("Vertical");
		a.z = ver;
		transform.Translate(a * Time.deltaTime * 3);
		if (Input.GetButtonDown("Jump")) {
            player.AddForce(transform.up * jumppower);
		}
	}
	
	public void Restart () {
		if (health <= 0) {
			Scene scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene(scene.name);
			Detection.shotsHit = Detection.shotsHit;
			Detection.shotsFired = Detection.shotsFired;
			Detection.headshot = Detection.headshot;
			Detection.points = Detection.points;
			Detection.time = Detection.time;
			Detection.accuracy = Detection.accuracy;
			Detection.shotsHit = 0;
			Detection.shotsFired = 0;
			Detection.headshot = 0;
			Detection.time = 0;
			Detection.accuracy = 100;
			Time.timeScale = 1;
		}
	}
}