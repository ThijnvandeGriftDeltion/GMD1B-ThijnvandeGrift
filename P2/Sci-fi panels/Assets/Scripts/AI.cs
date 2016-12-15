using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	
	public Transform player;
	public float movespeed = 4;
	public float mindist = 10;
	private RaycastHit hit;
	public float timer = 2;
	
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
						GameObject.Find("Body").GetComponent<FirstPerson>().health -= 1;
					}
				}
			}
		}
	}
}