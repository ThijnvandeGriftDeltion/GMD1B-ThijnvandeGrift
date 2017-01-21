using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	
	public int lives_Red_team;
	public int lives_Blue_team;
	public float blue_team_spawn_minX;
	public float blue_team_spawn_maxX;
	public float red_team_spawn_minX;
	public float red_team_spawn_maxX;
	public float blue_team_spawn_minZ;
	public float blue_team_spawn_maxZ;
	public float red_team_spawn_minZ;
	public float red_team_spawn_maxZ;
	public int y;
	public Vector3 red_team_spawn1;
	public Vector3 red_team_spawn2;
	public Vector3 red_team_spawn3;
	public Vector3 red_team_spawn4;
	public Vector3 blue_team_spawn1;
	public Vector3 blue_team_spawn2;
	public Vector3 blue_team_spawn3;
	public Vector3 blue_team_spawn4;
	public GameObject redplayer1;
	public GameObject redplayer2;
	public GameObject redplayer3;
	public GameObject redplayer4;
	public GameObject blueplayer1;
	public GameObject blueplayer2;
	public GameObject blueplayer3;
	public GameObject blueplayer4;
	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		float x_red_team_1 = Random.Range(red_team_spawn_minX, red_team_spawn_maxX);
		float z_red_team_1 = Random.Range(red_team_spawn_minZ, red_team_spawn_maxZ);
		float x_red_team_2 = Random.Range(red_team_spawn_minX, red_team_spawn_maxX);
		float z_red_team_2 = Random.Range(red_team_spawn_minZ, red_team_spawn_maxZ);		
		float x_red_team_3 = Random.Range(red_team_spawn_minX, red_team_spawn_maxX);
		float z_red_team_3 = Random.Range(red_team_spawn_minZ, red_team_spawn_maxZ);
		float x_red_team_4 = Random.Range(red_team_spawn_minX, red_team_spawn_maxX);
		float z_red_team_4 = Random.Range(red_team_spawn_minZ, red_team_spawn_maxZ);
		float x_blue_team_1 = Random.Range(blue_team_spawn_minX, blue_team_spawn_maxX);
		float z_blue_team_1 = Random.Range(blue_team_spawn_minZ, blue_team_spawn_maxZ);
		float x_blue_team_2 = Random.Range(blue_team_spawn_minX, blue_team_spawn_maxX);
		float z_blue_team_2 = Random.Range(blue_team_spawn_minZ, blue_team_spawn_maxZ);
		float x_blue_team_3 = Random.Range(blue_team_spawn_minX, blue_team_spawn_maxX);
		float z_blue_team_3 = Random.Range(blue_team_spawn_minZ, blue_team_spawn_maxZ);
		float x_blue_team_4 = Random.Range(blue_team_spawn_minX, blue_team_spawn_maxX);
		float z_blue_team_4 = Random.Range(blue_team_spawn_minZ, blue_team_spawn_maxZ);
		red_team_spawn1 = new Vector3(x_red_team_1, y, z_red_team_1);
		red_team_spawn2 = new Vector3(x_red_team_2, y, z_red_team_2);
		red_team_spawn3 = new Vector3(x_red_team_3, y, z_red_team_3);
		red_team_spawn4 = new Vector3(x_red_team_4, y, z_red_team_4);
		blue_team_spawn1 = new Vector3(x_blue_team_1, y, z_blue_team_1);
		blue_team_spawn2 = new Vector3(x_blue_team_2, y, z_blue_team_2);
		blue_team_spawn3 = new Vector3(x_blue_team_3, y, z_blue_team_3);
		blue_team_spawn4 = new Vector3(x_blue_team_4, y, z_blue_team_4);
		blueplayer1.transform.position = blue_team_spawn1;
		blueplayer2.transform.position = blue_team_spawn2;
		blueplayer3.transform.position = blue_team_spawn3;
		blueplayer4.transform.position = blue_team_spawn4;
		redplayer1.transform.position = red_team_spawn1;
		redplayer2.transform.position = red_team_spawn2;
		redplayer3.transform.position = red_team_spawn3;
		redplayer4.transform.position = red_team_spawn4;
		if (player.transform.tag == "Red_team") {
			Destroy(redplayer1);
			player.transform.position = red_team_spawn1;
		}
		else if (player.transform.tag == "Blue_team") {
			Destroy(blueplayer1);
			player.transform.position = blue_team_spawn1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}