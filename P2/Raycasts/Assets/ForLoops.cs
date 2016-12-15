using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForLoops : MonoBehaviour {
	
	public List<bool> b = new List<bool>();

	// Use this for initialization
	void Start () {
		for(int i = 0; i < 10; i++) {
			if (b[i] == true) {
				print(i + " I'm true");
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
