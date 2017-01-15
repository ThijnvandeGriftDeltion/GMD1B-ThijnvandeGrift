using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FirstPerson : MonoBehaviour {
	
	public Vector3 a;
	public float hor;
	public float ver;
	public Rigidbody player;
	public float jumppower;
	private float jumptimer;
	public float jumpreset;
	public float rotationY;
	public float viewRange;
	public int mouseSensitivity;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		jumptimer -= Time.deltaTime;
		float rotationX = Input.GetAxis("Mouse X") * mouseSensitivity;
		transform.Rotate (0, rotationX, 0);
		rotationY -= Input.GetAxis("Mouse Y") * mouseSensitivity;
		rotationY = Mathf.Clamp (rotationY, -viewRange, viewRange);
		Camera.main.transform.localRotation = Quaternion.Euler (rotationY, 0, 0);
		hor = Input.GetAxis("Horizontal");
		a.x = hor;
		ver = Input.GetAxis("Vertical");
		a.z = ver;
		transform.Translate(a * Time.deltaTime * GameObject.Find("PlayerManager").GetComponent<PlayerManager>().movement);
		if (Input.GetButtonDown("Jump") && jumptimer <= 0) {
            player.AddForce(transform.up * jumppower);
			jumptimer = jumpreset;
		}
	}
}