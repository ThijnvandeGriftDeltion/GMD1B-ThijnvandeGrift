using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Win : MonoBehaviour {
	
	public GameObject player;
	public GameObject spawnplayer;
	public Vector3 spawn;
	public GameObject player2;
	public GameObject spawnplayer2;
	public Vector3 spawn2;
	public static int scoreplayer1;
	public static int scoreplayer2;
	public Text score1;
	public Text score2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnCollisionEnter (Collision C) {
		if (C.gameObject.tag == ("Player")) {
			spawn = spawnplayer.transform.position;
			Instantiate(player, spawn, Quaternion.identity);
			spawn2 = spawnplayer2.transform.position;
			Instantiate(player2, spawn2, Quaternion.identity);
			Destroy(C.gameObject);
			Destroy(GameObject.FindWithTag("Player2"));
			scoreplayer1 = scoreplayer1;
			scoreplayer1 = scoreplayer1 += 1;
			score1.text = scoreplayer1.ToString ();
		}
		else if (C.gameObject.tag == ("Player2")) {
			spawn2 = spawnplayer2.transform.position;
			Instantiate(player2, spawn2, Quaternion.identity);
			spawn = spawnplayer.transform.position;
			Instantiate(player, spawn, Quaternion.identity);
			Destroy(C.gameObject);
			Destroy(GameObject.FindWithTag("Player"));
			scoreplayer2 = scoreplayer2;
			scoreplayer2 = scoreplayer2 += 1;
			score2.text = scoreplayer2.ToString ();
		}
	}
}
