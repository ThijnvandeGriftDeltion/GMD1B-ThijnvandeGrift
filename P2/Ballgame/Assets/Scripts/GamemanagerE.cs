using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GamemanagerE : MonoBehaviour {
	
	public static int lives = 5;
	public static int livesplayer2 = 5;
	public GameObject sphere;
	public GameObject goodsphere;
	public float min = 0;
	public float max = 20;
	public float minplus = 0;
	public float maxplus = 20;
	public Vector3 x;
	public Vector3 xplus;
	public float timer = 1f;
	public float timer2 = 2f;
	public Text livesdisplay;
	public Text livesdisplay2;
	public float timergame;
	public Text timepassed;
	public GameObject gameover;
	public bool extra = false;

	// Use this for initialization
	void Start () {
		lives = 5;
		timergame = 0f;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		timer2 -= Time.deltaTime;
		if (timer <= 0) {
			TimedSpawn();
			timer = 1f;
			livesdisplay.text = lives.ToString ();
			livesdisplay2.text = livesplayer2.ToString ();
		}
		if (timer2 <= 0) {
			TimedSpawnGood();
			timer2 = 1f;
		}
		timergame += Time.deltaTime;
		timepassed.text = timergame.ToString ();
		GameOver();
		if (timergame >= 30 && extra == false) {
			lives += 2;
			livesplayer2 += 2;
			extra = true;
		}
	}
	
	public void TimedSpawn () {
		float x = Random.Range(min,max);
		Instantiate (sphere, new Vector3(x,15,-1), Quaternion.identity);
	}
	
	public void TimedSpawnGood () {
		float xplus = Random.Range(minplus,maxplus);
		Instantiate (goodsphere, new Vector3(xplus,15,-1), Quaternion.identity);
	}
	
	public void GameOver () {
		if (lives == 0) {
			gameover.SetActive(true);
		}
		else if (livesplayer2 == 0) {
			gameover.SetActive(true);
		}
	}
}