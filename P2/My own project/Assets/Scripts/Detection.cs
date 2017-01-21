using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Detection : MonoBehaviour {
	
	//Ints
	public int totalbullets;
	public int reloadedbullets;
	public int bullets;
	public int health;
	public int armor;
	public int incomingdamage;
	public int enemydamage;
	
	//UI
	public Text bulletsui;
	public Text healthui;
	
	//Floats
	public float timershot;
	private float resettimer = .75f;
	private float reload;
	private float reloadtime = 2;
	private float timebetweenshot;
	private float timerbetweenshot = 1f;
	public static float time;
	
	//GameObjects
	public GameObject grenade;
	public GameObject grenadelauncher;
	public GameObject barrel;
	public GameObject body;
	public GameObject playerManager;
	
	//Vector3
	private Vector3 barrelpos;
	
	//RaycastHit
	public RaycastHit hit;
	
	//Bools
	public bool aim = false;
	public bool startreload = false;
	public bool hitbyenemy;

	// Use this for initialization
	void Start () {
		reload = reloadtime;
		Cursor.visible = false;
		health = playerManager.GetComponent<PlayerManager>().hp;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastUse();
		Shoot ();
		Timer ();
		Aim ();
		Reload ();
		Restart ();
	}
	
	//Instantiate a grenade and reload the gun when it's out of ammo.	
	public void Shoot () {
		barrelpos = GameObject.Find("Barrel").transform.position;
		if (timershot > 0) {
			barrel.transform.Rotate(new Vector3(0,0,+1.85f));
		}
		if (bullets == 0) {
			Reload ();
			startreload = true;
		}
		if(Input.GetButtonDown("Fire1") && timebetweenshot <= 0 && bullets > 0 && totalbullets > 0 && startreload == false) {
			reloadedbullets += 1;
			Instantiate(grenade, barrelpos, Quaternion.Euler(0, 90, 0));
			timershot = resettimer;
			timebetweenshot = timerbetweenshot;
			bullets -= 1;
		}
	}
	
	//Aim down sights with the gun for more accuracy.
	public void Aim () {
		if (Input.GetButtonDown("Fire2") && aim == false) {
			grenadelauncher.transform.Translate(new Vector3(-.4f,-.2f,0));
			aim = true;
		}
		else if (Input.GetButtonDown("Fire2") && aim == true) {
			grenadelauncher.transform.Translate(new Vector3(.4f,.2f,0));
			aim = false;
		}
	}
	
	//All time based components.
	public void Timer () {
		health = playerManager.GetComponent<PlayerManager>().hp;
		timershot -= Time.deltaTime;
		timebetweenshot -= Time.deltaTime;
		bulletsui.text = bullets.ToString();
		healthui.text = health.ToString();
	}
	
	
	//Reload the weapon.
	public void Reload () {
		if (Input.GetButtonDown("R") && bullets < 8) {
			startreload = true;
			totalbullets = totalbullets - reloadedbullets;
		}
		if (reload > 0 && startreload == true) {
			barrel.transform.Rotate(new Vector3(0,0,6));
			reload -= Time.deltaTime;
		}
		else if (reload <= 0 && startreload == true) {
			totalbullets = totalbullets - reloadedbullets;
			reloadedbullets = 0;
			bullets = 8;
			reload = reloadtime;
			startreload = false;
		}
	}
	
	//A use button.
	public void RaycastUse () {
		if (Physics.Raycast(transform.position, transform.forward, out hit, 2)) {
			if (Input.GetButtonDown("E")) {
				if (hit.transform.tag == "Door") {
					hit.transform.Rotate(new Vector3(0,90,0));
					hit.transform.gameObject.GetComponent<Door>().dooropen = true;
				}
			}
		}
	}
	
	//Restarts the game when health drops below 0
	public void Restart () {
		if (health <= 0) {
			Scene scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene(scene.name);
			Time.timeScale = 1;
		}
	}
}