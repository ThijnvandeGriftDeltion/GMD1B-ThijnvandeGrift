using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public GameObject[] groups;

	// Use this for initialization
	void Start () {
		SpawnNext ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void SpawnNext () {
		int i = Random.Range(0, groups.Length);
		Instantiate(groups[i], transform.position, Quaternion.identity);
	}
}
