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
	public GameObject gamemanager;
	
	//When you click the play button it activates a different panel.
	public void Play () {
		play.SetActive(false);
		team.SetActive(true);
	}
	
	//Changes the tag to the team choice when you click this button.
	public void TeamChoiceRed () {
		team.SetActive(false);
		player.transform.tag = "Red_team";
		classes.SetActive(true);
	}
	
	//Changes the tag to the team choice when you click this button.
	public void TeamChoiceBlue () {
		team.SetActive(false);
		player.transform.tag = "Blue_team";
		classes.SetActive(true);
	}
	
	//Switches to the Bathroom scene and sets some variables to false.
	public void Level1 () {
		SceneManager.LoadScene("Bathroom");
		gamemanager.GetComponent<GameManager>().deadEnemy[0] = false;
		gamemanager.GetComponent<GameManager>().deadEnemy[1] = false;
		gamemanager.GetComponent<GameManager>().deadEnemy[2] = false;
		gamemanager.GetComponent<GameManager>().deadEnemy[3] = false;
		gamemanager.GetComponent<GameManager>().deadEnemy[4] = false;
		gamemanager.GetComponent<GameManager>().deadEnemy[5] = false;
		gamemanager.GetComponent<GameManager>().deadEnemy[6] = false;
		gamemanager.GetComponent<GameManager>().deadEnemy[7] = false;
		gamemanager.GetComponent<GameManager>().spawnset = false;
		gamemanager.GetComponent<GameManager>().blueplayer1.transform.position = gamemanager.GetComponent<GameManager>().blue_team_spawn1;
		gamemanager.GetComponent<GameManager>().blueplayer2.transform.position = gamemanager.GetComponent<GameManager>().blue_team_spawn2;
		gamemanager.GetComponent<GameManager>().blueplayer3.transform.position = gamemanager.GetComponent<GameManager>().blue_team_spawn3;
		gamemanager.GetComponent<GameManager>().blueplayer4.transform.position = gamemanager.GetComponent<GameManager>().blue_team_spawn4;
		gamemanager.GetComponent<GameManager>().redplayer1.transform.position = gamemanager.GetComponent<GameManager>().red_team_spawn1;
		gamemanager.GetComponent<GameManager>().redplayer2.transform.position = gamemanager.GetComponent<GameManager>().red_team_spawn2;
		gamemanager.GetComponent<GameManager>().redplayer3.transform.position = gamemanager.GetComponent<GameManager>().red_team_spawn3;
		gamemanager.GetComponent<GameManager>().redplayer4.transform.position = gamemanager.GetComponent<GameManager>().red_team_spawn4;
		gamemanager.GetComponent<GameManager>().spawnset = true;
	}
	
	//Sets the Demolition class active when you click this button.
	public void Demolition () {
		grenade.SetActive(true);
		level.SetActive(true);
		classes.SetActive(false);
	}
}
