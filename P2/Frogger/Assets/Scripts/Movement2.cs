using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour {
	
	public Vector3 a;
	public float hor;
	public float ver;
	public GameObject player;
	public GameObject spawnplayer;
	public Vector3 spawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		hor = Input.GetAxis("Horizontal1");
		a.x = hor;
		ver = Input.GetAxis("Vertical1");
		a.z = ver;
		transform.Translate(a * Time.deltaTime);
	}
	
	public void OnCollisionEnter (Collision C) {
		if (C.gameObject.tag == ("Cube")) {
			spawn = spawnplayer.transform.position;
			Instantiate(player, spawn, Quaternion.identity);
			Destroy(gameObject);
		}
	}
}
