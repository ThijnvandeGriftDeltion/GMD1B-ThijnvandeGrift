using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour {
	
	public GameObject target;
	public float minx = -4.5f;
	public float maxx = 44.5f;
	public float minz = -24.5f;
	public float maxz = 24.5f;
	public float y = .5f;
	public float timer = 2;
	public static int enemies = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (enemies < 8) {
			SpawnEnemy ();
		}
	}
	
	public void SpawnEnemy () {
		if (timer <= 0) {
		float x = Random.Range(minx,maxx);
		float z = Random.Range(minz,maxz);
		Instantiate(target, new Vector3(x,y,z), Quaternion.identity);
		timer = 2;
		enemies += 1;
		}
	}
}
