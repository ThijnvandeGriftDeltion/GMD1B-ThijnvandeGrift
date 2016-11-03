using UnityEngine;
using System.Collections;

public class BonusBall : MonoBehaviour {
	
	public GameObject prefab;
	public GameObject spawnlocation;
	public GameObject spot;
	public bool spawned;
	public ParticleSystem particles;

	//Spawns an extra "bonus" ball, turns on a light and plays some particles.
	public void OnCollisionEnter (Collision C) {
		if (spawned == false) {
		Instantiate(prefab, spawnlocation.GetComponent<Transform>().position, spawnlocation.GetComponent<Transform>().rotation);
		spot.SetActive(true);
		StartCoroutine(Disable());
		spawned = true;
		particles.Play();
		}
	}
	
	private IEnumerator Disable() {
		yield return new WaitForSeconds (3);
		spot.SetActive(false);
	}
}