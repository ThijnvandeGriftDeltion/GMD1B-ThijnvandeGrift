using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float hor;
	public float hor2;
	public Vector3 move;
	public Vector3 move2;
	public int speed;
	public GameObject player;
	public GameObject player2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		hor = Input.GetAxis("Horizontal");
		move.z = hor;
		player.transform.Translate(move * Time.deltaTime * speed);
		hor2 = Input.GetAxis("Horizontal2");
		move2.z = hor2;
		player2.transform.Translate(move2 * Time.deltaTime * speed);
		
	}
}
