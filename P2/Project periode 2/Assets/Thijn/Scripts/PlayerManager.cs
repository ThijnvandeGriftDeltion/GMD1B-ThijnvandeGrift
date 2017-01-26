using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	
	public int weaponDamage;
	public int movement;
	public int playerlevel;
	public int playerxp;
	public int neededxp;
	public int hp;

	//Simple level system to level up.
	void Update () {
		if (playerxp >= neededxp) {
			playerlevel += 1;
			playerxp = playerxp - neededxp;
			neededxp = playerlevel * 150;
		}
	}
}
