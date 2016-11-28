using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Win2 : MonoBehaviour {
	
	public static int scoreplayer2;
	public Text score2;
	public Vector3 spawn2;
	public GameObject spawnplayer2;
	public GameObject player2;
	public GameObject player;
	public GameObject spawnplayer;
	public Vector3 spawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnCollisionEnter (Collision C) {
		if (C.gameObject.tag == ("Player2")) {
			spawn2 = spawnplayer2.transform.position;
			Instantiate(player2, spawn2, Quaternion.identity);
			spawn = spawnplayer.transform.position;
			Instantiate(player, spawn, Quaternion.identity);
			Destroy(C.gameObject);
			Destroy(GameObject.FindWithTag("Player1"));
			scoreplayer2 = scoreplayer2;
			scoreplayer2 = scoreplayer2 += 1;
			score2.text = scoreplayer2.ToString ();
		}
	}
}
