using UnityEngine;
using System.Collections;

public class Gunfire : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	
	void Update() {
        if(Input.GetButtonDown("Fire1"))
        {
            print(1);
            gameObject.SetActive(true);
        }
    }
}
