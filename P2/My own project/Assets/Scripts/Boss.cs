using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Boss : MonoBehaviour {
	
	public GameObject player;
	public float movespeed;
	public float minDist;
	private RaycastHit hit;
	public float timer;
	public float attackrange;
	public int bosshp;
	public GameObject bosshealthui;
	public Text bosshpui;
	public int weapondamage;
	public int trueweapondamage;
	
	void Update () {
		timer -= Time.deltaTime;
		transform.LookAt(player.transform.position);
		bosshpui.text = bosshp.ToString();
		if(Vector3.Distance(transform.position, player.transform.position) <= minDist) {
			transform.position += transform.forward * movespeed * Time.deltaTime;
			bosshealthui.SetActive(true);
		}
		if (Vector3.Distance(transform.position, player.transform.position) <= attackrange) {
			print("in range");
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
		if (bosshp <= 0) {
			GameObject.Find("BossBattleManager").GetComponent<BossBattle>().dead = true;
			GameObject.Find("PlayerManager").GetComponent<PlayerManager>().playerxp += 50;
			bosshealthui.SetActive(false);
			Destroy(gameObject);
		}
	}
}