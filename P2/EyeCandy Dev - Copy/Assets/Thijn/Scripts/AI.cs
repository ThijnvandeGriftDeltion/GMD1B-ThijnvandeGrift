using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	
	public float movespeed;
	public float attackrange;
	private RaycastHit hit;
	public float timer;
	public int hp;
	public int weaponDamage;
	public GameObject[] enemies;
	public GameObject enemy;
	public int index;
	public GameObject playermanager;
	public float newenemy;
	public int newenemytime;
	public Material Blue_team;
	public Material Red_team;
	
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
		if (transform.tag == "Blue_team") {
			GetComponent<Renderer>().material = Blue_team;
		}
		else if (transform.tag == "Red_team") {
			GetComponent<Renderer>().material = Red_team;
		}
		movespeed = playermanager.GetComponent<PlayerManager>().movement;
		weaponDamage = playermanager.GetComponent<PlayerManager>().weaponDamage;
	}
	
	void Update () {
		hp = playermanager.GetComponent<PlayerManager>().hp;
		newenemy -= Time.deltaTime;
		timer -= Time.deltaTime;
		if (transform.tag == "Red_team") {
		enemies = GameObject.FindGameObjectsWithTag("Blue_team");
		}
		if (transform.tag == "Blue_team") {
		enemies = GameObject.FindGameObjectsWithTag("Red_team");
		}
		index = Random.Range (0, enemies.Length);
		if (newenemy <= 0) {
			enemy = enemies[index];
			newenemy = newenemytime;
		}
		if (enemy == null) {
			enemy = enemies[index];
			newenemy = newenemytime;
		}
		transform.LookAt(enemy.transform);
		if(Vector3.Distance(transform.position, enemy.transform.position) > attackrange) {
			transform.position += transform.forward * movespeed * Time.deltaTime;
		}
		else {
			if (timer <= 0) {
				if (Physics.Raycast(transform.position, transform.forward, out hit, 100f)) {
					Debug.DrawLine (transform.position, hit.point, Color.red);
					timer = 2;
					if (hit.transform.tag == "Blue_team" && transform.tag == "Red_team") {
						hit.transform.GetComponent<PlayerManager>().hp -= weaponDamage;
					}
					if (hit.transform.tag == "Red_team" && transform.tag == "Blue_team") {
						hit.transform.GetComponent<PlayerManager>().hp -= weaponDamage;
					}
				}
			}
		}
		if (hp <= 0) {
			GameObject.Find("PlayerManager").GetComponent<PlayerManager>().playerxp += 5;
			Destroy(gameObject);
		}
	}
}