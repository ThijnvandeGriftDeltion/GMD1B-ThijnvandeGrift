using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	
	//AI werkt niet goed. Had geen tijd meer om te vragen wat ik fout deed ivm geen les toen ik hier mee bezig was.
	
	public float movespeed;
	public float attackrange;
	private RaycastHit hit;
	public float timer;
	public int hp;
	public int weaponDamage;
	public GameObject[] enemies;
	public GameObject enemy;
	public int index;
	public float newenemy;
	public int newenemytime;
	public Material Blue_team;
	public Material Red_team;
	public GameObject player;
	
	//Sets the team color to the bot.
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
		player = GameObject.Find("Player");
		if (transform.tag == "Blue_team") {
			GetComponent<Renderer>().material = Blue_team;
		}
		else if (transform.tag == "Red_team") {
			GetComponent<Renderer>().material = Red_team;
		}
	}
	
	//Update is called once every frame.
	void Update () {
		newenemy -= Time.deltaTime;
		timer -= Time.deltaTime;
		Death ();
		ChooseEnemyAndAttack ();
	}
	
	public void Death () {
		//If its health is 0 or below it gets destroyed.
		if (hp <= 0) {
			GameObject.Find("PlayerManagerM").GetComponent<PlayerManager>().playerxp += 5;
			Destroy(gameObject);
		}
	}
	
	//Counts all objects with the opposite team tag and orders them in a list. Chooses a random object out of that list as enemy and attacks it.
	public void ChooseEnemyAndAttack () {
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
				if (Physics.Raycast(transform.position, transform.forward, out hit, 20)) {
					Debug.DrawLine (transform.position, hit.point, Color.red);
					timer = 2;
					if (hit.transform.gameObject == player) {
						player.GetComponent<PlayerManager>().hp -= weaponDamage;
					}
					else {
						hit.transform.GetComponent<AI>().hp -= weaponDamage;
					}
				}
			}
		}
	}
}