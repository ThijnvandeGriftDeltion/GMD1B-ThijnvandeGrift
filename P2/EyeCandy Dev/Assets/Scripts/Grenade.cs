﻿using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour {
	
	private int force = 30000;
	public Rigidbody grenade;
	public bool shot;
	public Vector3 explosionPos;
	public float radius;
	public float power;
	public int weaponDamage;
	public GameObject player;

	// Use this for initialization
	void Start () {
		grenade = GetComponent<Rigidbody>();
		shot = false;		
	}
	
	// Update is called once per frame
	void Update () {
		if (shot == false) {
			grenade.AddForce(GameObject.Find("Main Camera").transform.forward * force);
			shot = true;
		}
		weaponDamage = GameObject.Find("PlayerManager").GetComponent<PlayerManager>().weaponDamage;
	}
	
	public void OnCollisionEnter (Collision C) {
		explosionPos = transform.position;
		ExplosionDamage ();
		print("I hit something");
		Destroy(gameObject);
	}
	
	public void ExplosionDamage () {
		Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders) {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null) {
                rb.AddExplosionForce(power, explosionPos, radius, 1);
				if (hit.transform.tag == "Blue_team" && player.transform.tag == "Red_team") {
					hit.GetComponent<AI>().hp -= weaponDamage;
				}
				if (hit.transform.tag == "Red_team" && player.transform.tag == "Blue_team") {
					hit.GetComponent<AI>().hp -= weaponDamage;
				}
			}
		}
	}
}