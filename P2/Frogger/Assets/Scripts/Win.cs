using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Win : MonoBehaviour {
	
	public GameObject player;
	public GameObject spawnplayer;
	public Vector3 spawn;
	public static int scoreplayer1;
	public Text score1;
	public GameObject player2;
	public GameObject spawnplayer2;
	public Vector3 spawn2;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnCollisionEnter (Collision C) {
		if (C.gameObject.tag == ("Player1")) {
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
	}
}
