using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	
	public Transform player;
	public float movespeed = 4;
	public float mindist = 10;
	private RaycastHit hit;
	public float timer = 2;
	public int hp;
	public int weapondamage;
	public int trueweapondamage;
	
	void Update () {
		timer -= Time.deltaTime;
		player = GameObject.Find("Body").transform;
		transform.LookAt(player);
		if(Vector3.Distance(transform.position, player.position) >= mindist) {
			transform.position += transform.forward * movespeed * Time.deltaTime;
		}
		else {
			if (timer <= 0) {
				if (Physics.Raycast(transform.position, transform.forward, out hit, 100f)) {
					Debug.DrawLine (transform.position, hit.point, Color.red);
					timer = 2;
					if (hit.transform.tag == "Player") {
						trueweapondamage = weapondamage - GameObject.Find("PlayerManager").GetComponent<PlayerManager>().armor;
						GameObject.Find("PlayerManager").GetComponent<PlayerManager>().hp -= trueweapondamage;
					}
				}
			}
		}
		if (hp <= 0) {
			GameObject.Find("PlayerManager").GetComponent<PlayerManager>().playerxp += 5;
			GameObject.Find("Gamemanager").GetComponent<Gamemanager>().enemies -= 1;
			Destroy(gameObject);
		}
	}
}