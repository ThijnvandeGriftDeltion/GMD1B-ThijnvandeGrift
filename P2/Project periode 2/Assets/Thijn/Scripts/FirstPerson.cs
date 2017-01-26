﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FirstPerson : MonoBehaviour {
	
	public Vector3 a;
	public float hor;
	public float ver;
	public Rigidbody player;
	public float jumppower;
	private float jumptimer;
	public float jumpreset;
	public float rotationY;
	public float viewRange;
	public int mouseSensitivity;
	public Material Blue_team;
	public Material Red_team;
	public int hp;
	
	//Sets the team color based on the team tag.
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
	}
	
	//Ability to move, look around and jump.
	void Update () {
		hp = GameObject.Find("PlayerManagerM").GetComponent<PlayerManager>().hp;
		jumptimer -= Time.deltaTime;
		float rotationX = Input.GetAxis("Mouse X") * mouseSensitivity;
		transform.Rotate (0, rotationX, 0);
		rotationY -= Input.GetAxis("Mouse Y") * mouseSensitivity;
		rotationY = Mathf.Clamp (rotationY, -viewRange, viewRange);
		Camera.main.transform.localRotation = Quaternion.Euler (rotationY, 0, 0);
		hor = Input.GetAxis("Horizontal");
		a.x = hor;
		ver = Input.GetAxis("Vertical");
		a.z = ver;
		transform.Translate(a * Time.deltaTime * GameObject.Find("PlayerManagerM").GetComponent<PlayerManager>().movement);
		if (Input.GetButtonDown("Jump") && jumptimer <= 0) {
            player.AddForce(transform.up * jumppower);
			jumptimer = jumpreset;
		}
		if (transform.tag == "Blue_team") {
			GetComponent<Renderer>().material = Blue_team;
		}
		else if (transform.tag == "Red_team") {
			GetComponent<Renderer>().material = Red_team;
		}
	}
}