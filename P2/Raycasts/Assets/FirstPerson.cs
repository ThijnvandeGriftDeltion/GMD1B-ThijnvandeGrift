using UnityEngine;
using System.Collections;

public class FirstPerson : MonoBehaviour {
	
	public Vector3 move;
	public Vector3 move2;
	public GameObject hoofd;
	public Vector3 a;
	public float hor;
	public float ver;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		move2.y = Input.GetAxis("Mouse X");
		transform.Rotate(move2);
		move.x = -Input.GetAxis("Mouse Y");
		hoofd.transform.Rotate(move);
		hor = Input.GetAxis("Horizontal");
		a.x = hor;
		ver = Input.GetAxis("Vertical");
		a.z = ver;
		transform.Translate(a * Time.deltaTime * 2);
	}
}