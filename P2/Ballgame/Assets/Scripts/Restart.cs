using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public void Restartgame () {
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
		Gamemanager.lives = Gamemanager.lives;
		Gamemanager.lives = 3;
		Gamemanager.livesplayer2 = Gamemanager.livesplayer2;
		Gamemanager.livesplayer2 = 3;
		GamemanagerE.lives = GamemanagerE.lives;
		GamemanagerE.lives = 5;
		GamemanagerE.livesplayer2 = GamemanagerE.livesplayer2;
		GamemanagerE.livesplayer2 = 5;
		GamemanagerHC.lives = GamemanagerHC.lives;
		GamemanagerHC.lives = 1;
		GamemanagerHC.livesplayer2 = GamemanagerHC.livesplayer2;
		GamemanagerHC.livesplayer2 = 1;
	}
	
	public void BackToMenu () {
		SceneManager.LoadScene("Menu");
	}
}
