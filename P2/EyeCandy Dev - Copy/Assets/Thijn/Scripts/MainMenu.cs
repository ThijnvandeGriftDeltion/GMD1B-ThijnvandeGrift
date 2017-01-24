using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	
	public GameObject play;
	public GameObject level;
	public GameObject classes;
	public GameObject team;
	public GameObject player;
	public GameObject grenade;
	public GameObject scout;
	public GameObject waterthrower;
	public GameObject shotgun;
	public GameObject gamemanager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Play () {
		play.SetActive(false);
		team.SetActive(true);
	}
	
	public void TeamChoiceRed () {
		team.SetActive(false);
		player.transform.tag = "Red_team";
		classes.SetActive(true);
	}
	
	public void TeamChoiceBlue () {
		team.SetActive(false);
		player.transform.tag = "Blue_team";
		classes.SetActive(true);
	}
	
	public void Level1 () {
		SceneManager.LoadScene("Bathroom");
		gamemanager.GetComponent<GameManager>().level = 1;
		gamemanager.GetComponent<GameManager>().blue_team_spawn_minX = 10;
		gamemanager.GetComponent<GameManager>().blue_team_spawn_maxX = 20;
		gamemanager.GetComponent<GameManager>().red_team_spawn_minX = -5;
		gamemanager.GetComponent<GameManager>().red_team_spawn_maxX = 5;
		gamemanager.GetComponent<GameManager>().blue_team_spawn_minZ = 0;
		gamemanager.GetComponent<GameManager>().blue_team_spawn_maxZ = 10;
		gamemanager.GetComponent<GameManager>().red_team_spawn_minZ = 25;
		gamemanager.GetComponent<GameManager>().red_team_spawn_maxZ = 35;
		gamemanager.GetComponent<GameManager>().y = 2;
	}
	
	public void Level2 () {
		SceneManager.LoadScene("Water Facility");
		gamemanager.GetComponent<GameManager>().level = 2;
		gamemanager.GetComponent<GameManager>().blue_team_spawn_minX = 95;
		gamemanager.GetComponent<GameManager>().blue_team_spawn_maxX = 105;
		gamemanager.GetComponent<GameManager>().red_team_spawn_minX = 190;
		gamemanager.GetComponent<GameManager>().red_team_spawn_maxX = 200;
		gamemanager.GetComponent<GameManager>().blue_team_spawn_minZ = 110;
		gamemanager.GetComponent<GameManager>().blue_team_spawn_maxZ = 120;
		gamemanager.GetComponent<GameManager>().red_team_spawn_minZ = 220;
		gamemanager.GetComponent<GameManager>().red_team_spawn_maxZ = 230;
		gamemanager.GetComponent<GameManager>().y = 355;
	}
	
	public void Level3 () {
		SceneManager.LoadScene("Lake");
		gamemanager.GetComponent<GameManager>().level = 3;
	}
	
	public void Level4 () {
		SceneManager.LoadScene("Water Park");
		gamemanager.GetComponent<GameManager>().level = 4;
	}
	
	public void Soldier () {
		shotgun.SetActive(true);
		level.SetActive(true);
		classes.SetActive(false);
	}
	
	public void Demolition () {
		grenade.SetActive(true);
		level.SetActive(true);
		classes.SetActive(false);
	}
	
	public void Heavy () {
		waterthrower.SetActive(true);
		level.SetActive(true);
		classes.SetActive(false);
	}
	
	public void Scout () {
		scout.SetActive(true);
		level.SetActive(true);
		classes.SetActive(false);
	}
}
