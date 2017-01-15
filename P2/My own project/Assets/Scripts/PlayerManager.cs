using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	
	public GameObject weapon;
	public int weaponDamage;
	public int armor;
	public int movement;
	public int playerlevel;
	public int playerxp;
	public int neededxp;
	public int hp;
	public int maxhp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (playerxp >= neededxp) {
			playerlevel += 1;
			playerxp = playerxp - neededxp;
			neededxp = playerlevel * 150;
			armor = armor + playerlevel * 2;
			weaponDamage = weaponDamage + playerlevel * 2;
			maxhp = maxhp * playerlevel * 2;
		}
	}
}
