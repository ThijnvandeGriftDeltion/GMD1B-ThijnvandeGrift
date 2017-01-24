using UnityEngine;
using System.Collections;

public class SuperButton : MonoBehaviour {
	
	public enum State {
		Een,
		Twee,
	}
	
	public State state;
	public GameObject elevator;
	public Transform level1;
	public Transform level2;
	public Transform dooropen1;
	public Transform dooropen2;
	public Transform doorclose1;
	public Transform doorclose2;
	public float speed;
	public bool doorsClosed;
	public GameObject door1;
	public GameObject door2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (state == State.Een) {
			doorsClosed = true;
			if (Vector3.Distance(door1.transform.position, doorclose1.position) == 0) {
			elevator.transform.position = Vector3.MoveTowards(elevator.transform.position, level1.position, speed * Time.deltaTime);
			}
			if (Vector3.Distance(elevator.transform.position, level1.position) == 0) {
				doorsClosed = false;
			}
		}
		if (state == State.Twee) {
			doorsClosed = true;
			if (Vector3.Distance(door1.transform.position, doorclose1.position) == 0) {
			elevator.transform.position = Vector3.MoveTowards(elevator.transform.position, level2.position, speed * Time.deltaTime);
			}
			if (Vector3.Distance(elevator.transform.position, level2.position) == 0) {
				doorsClosed = false;
			}
		}
		if (doorsClosed == true) {
			door1.transform.position = Vector3.MoveTowards(door1.transform.position, doorclose1.position, speed * Time.deltaTime);
			door2.transform.position = Vector3.MoveTowards(door2.transform.position, doorclose2.position, speed * Time.deltaTime);
		}
		if (doorsClosed == false) {
			door1.transform.position = Vector3.MoveTowards(door1.transform.position, dooropen1.position, speed * Time.deltaTime);
			door2.transform.position = Vector3.MoveTowards(door2.transform.position, dooropen2.position, speed * Time.deltaTime);
		}
	}
}