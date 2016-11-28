using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Spawn : MonoBehaviour {
	
	public float timer = 1;
	public GameObject spawnrow1;
	public GameObject row1;
	public GameObject row2;
	public GameObject row3;
	public GameObject row4;
	public GameObject row5;
	public GameObject spawnrow2;
	public GameObject spawnrow3;
	public GameObject spawnrow4;
	public GameObject spawnrow5;
	public Vector3 spawningplace;
	public Vector3 spawningplace2;
	public Vector3 spawningplace3;
	public Vector3 spawningplace4;
	public Vector3 spawningplace5;
	public float gametimer;
	public Text time;
	public float timerrandom = 2;
	public float size = .3f;
	public float minsize = .2f;
	public float maxsize = 2;
	public float min = 2;
	public float max = 4;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Spawning ();
		gametimer += Time.deltaTime;
		time.text = gametimer.ToString ();
	}
	
	public void Spawning () {
		timer -= Time.deltaTime;
		timerrandom -= Time.deltaTime;
		if (timer <= 0) {
			spawningplace = spawnrow1.transform.position;
			row1.transform.localScale = new Vector3(0.5f, 0.3f, size);
			Instantiate(row1, spawningplace, Quaternion.identity);
			size = Random.Range(minsize, maxsize);
			spawningplace2 = spawnrow2.transform.position;
			Instantiate(row2, spawningplace2, Quaternion.Euler(0, 180, 0));
			spawningplace4 = spawnrow4.transform.position;
			Instantiate(row4, spawningplace4, Quaternion.Euler(0, 180, 0));
			timer = 1.5f;
		}
		if (timerrandom <= 0) {
			spawningplace3 = spawnrow3.transform.position;
			Instantiate(row3, spawningplace3, Quaternion.identity);
			spawningplace5 = spawnrow5.transform.position;
			Instantiate(row5, spawningplace5, Quaternion.identity);
			timerrandom = Random.Range(min, max);
		}
	}
}
