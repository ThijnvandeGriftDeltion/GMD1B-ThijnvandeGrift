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
	private float jumptimer;
	public float jumpreset;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		jumptimer -= Time.deltaTime;
		move2.y = Input.GetAxis("Mouse X");
		transform.Rotate(move2);
		move.x = -Input.GetAxis("Mouse Y");
		hoofd.transform.Rotate(move);
		hor = Input.GetAxis("Horizontal");
		a.x = hor;
		ver = Input.GetAxis("Vertical");
		a.z = ver;
		transform.Translate(a * Time.deltaTime * 4);
		if (Input.GetButtonDown("Jump") && jumptimer <= 0) {
            player.AddForce(transform.up * jumppower);
			jumptimer = jumpreset;
		}
	}
}