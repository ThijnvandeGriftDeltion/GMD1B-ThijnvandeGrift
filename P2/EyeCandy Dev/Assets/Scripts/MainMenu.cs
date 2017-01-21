using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	
	public GameObject play;
	public GameObject level;
	public GameObject team;
	public GameObject player;
	public GameObject grenade;

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
		level.SetActive(true);
		player.transform.tag = "Red_team";
	}
	
	public void TeamChoiceBlue () {
		team.SetActive(false);
		level.SetActive(true);
		player.transform.tag = "Blue_team";
	}
	
	public void Level1 () {
		SceneManager.LoadScene("Bathroom");
		grenade.GetComponent<GrenadeLauncher>().enabled = true;
	}
	
	public void Level2 () {
		SceneManager.LoadScene("Bathroom");
		grenade.GetComponent<GrenadeLauncher>().enabled = true;
	}
	
	public void Level3 () {
		SceneManager.LoadScene("Bathroom");
		grenade.GetComponent<GrenadeLauncher>().enabled = true;
	}
	
	public void Level4 () {
		SceneManager.LoadScene("Bathroom");
		grenade.GetComponent<GrenadeLauncher>().enabled = true;
	}
}
