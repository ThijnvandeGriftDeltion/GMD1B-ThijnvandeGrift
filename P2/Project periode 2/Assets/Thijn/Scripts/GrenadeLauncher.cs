using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GrenadeLauncher : MonoBehaviour {
	
	//Ints
	public int totalbullets;
	public int reloadedbullets;
	public int bullets;
	
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
	
	//Bools
	public bool startreload = false;

	// Use this for initialization
	void Start () {
		reload = reloadtime;
	}
	
	// Update is called once per frame
	void Update () {
		Shoot ();
		Reload ();
	}
	
	//Instantiate a grenade and reload the gun when it's out of ammo.	
	public void Shoot () {
		timershot -= Time.deltaTime;
		timebetweenshot -= Time.deltaTime;
		barrelpos = GameObject.Find("Barrel").transform.position;
		if (timershot > 0) {
			barrel.transform.Rotate(new Vector3(0,0,+92.5f) * Time.deltaTime);
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
	
	//Reload the weapon.
	public void Reload () {
		if (Input.GetButtonDown("R") && bullets < 8) {
			startreload = true;
			totalbullets = totalbullets - reloadedbullets;
		}
		if (reload > 0 && startreload == true) {
			barrel.transform.Rotate(new Vector3(0,0,270) * Time.deltaTime);
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
}