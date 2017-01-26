using UnityEngine;
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

	//Gets its own rigidbody as variable.
	void Start () {
		grenade = GetComponent<Rigidbody>();
		shot = false;		
	}
	
	//Applies a force to its rigidbody to launch itself away.
	void Update () {
		if (shot == false) {
			grenade.AddForce(GameObject.Find("Main Camera").transform.forward * force);
			shot = true;
		}
	}
	
	//When it hits something it creates an explosion at it position and then destroys itself.
	public void OnCollisionEnter (Collision C) {
		ExplosionDamage ();
		Destroy(gameObject);
	}
	
	//Creates a sphere and gets all colliders in that sphere. Then it applies a force to all those colliders and deals damage to them.
	public void ExplosionDamage () {
		Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders) {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null) {
                rb.AddExplosionForce(power, explosionPos, radius, 1);
			}
		}
	}
}