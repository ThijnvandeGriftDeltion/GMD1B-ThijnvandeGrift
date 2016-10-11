using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {
	
	public Button knop;
	public Button knop2;
	public Button knop3;
	public Button knop4;
	public Button knop5;
	public Button knop6;
	public Text tekst;
	public Text tekst2;
	public int getal;
	public Text add;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	public void Geklikt () {
		getal = getal + 1;
		add.text = "Getal: " + getal.ToString ();
	}
}
