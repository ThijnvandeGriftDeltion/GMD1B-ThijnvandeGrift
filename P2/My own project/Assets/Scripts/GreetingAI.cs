using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GreetingAI : MonoBehaviour {
	
	public enum State {
		Nul,
		Een,
		Twee,
		Drie,
		Vier,
		Vijf,
		Zes,
		Zeven,
		Acht,
		Negen,
		Tien
	}
	
	public State state;
	public GameObject player;
	public GameObject playermanager;
	public GameObject greetUI;
	public Text optionText1;
	public Text optionText2;
	public Text greeting;
	public Text optionText1A;
	public Text optionText2A;
	public Text greetingA;
	public Text optionText1B;
	public Text optionText2B;
	public Text greetingB;
	public Text optionText1C;
	public Text optionText2C;
	public Text greetingC;
	public Text optionText1D;
	public Text optionText2D;
	public Text greetingD;
	public Text optionText1E;
	public Text optionText2E;
	public Text greetingE;
	public Text optionText1F;
	public Text optionText2F;
	public Text greetingF;
	public Text optionText1G;
	public Text greetingG;
	public Text optionText1H;
	public Text greetingH;
	public Text optionText1I;
	public Text greetingI;
	public Text optionText1J;
	public Text greetingJ;
	public GameObject option1;
	public GameObject option2;
	public GameObject option1A;
	public GameObject option2A;
	public GameObject option1B;
	public GameObject option2B;
	public GameObject option1C;
	public GameObject option2C;
	public GameObject option1D;
	public GameObject option2D;
	public GameObject option1E;
	public GameObject option2E;
	public GameObject option1F;
	public GameObject option2F;
	public GameObject option1G;
	public GameObject option1H;
	public GameObject option1I;
	public GameObject option1J;
	public GameObject greetingGZ;
	public GameObject greetingGA;
	public GameObject greetingGB;
	public GameObject greetingGC;
	public GameObject greetingGD;
	public GameObject greetingGE;
	public GameObject greetingGF;
	public GameObject greetingGG;
	public GameObject greetingGH;
	public GameObject greetingGI;
	public GameObject greetingGJ;
	public int bullets;

	// Use this for initialization
	void Start () {
		greetUI.SetActive(true);
		Cursor.visible = true;
		playermanager.GetComponent<PlayerManager>().movement = 0;
		player.GetComponent<FirstPerson>().mouseSensitivity = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(player.transform.position);
		GreetPlayer ();
	}
	
	public void GreetPlayer () {
		if (state == State.Nul) {
			GameObject.Find("Main Camera").GetComponent<Detection>().enabled = false;
			greetingGZ.SetActive(true);
			option1.SetActive(true);
			option2.SetActive(true);
			greeting.text = "Hello there stranger.";
			optionText1.text = "Goodday to you sir.";
			optionText2.text = "What do you want old man?";
		}
		if (state == State.Een) {
			greetingGZ.SetActive(false);
			option1.SetActive(false);
			option2.SetActive(false);
			greetingGA.SetActive(true);
			option1A.SetActive(true);
			option2A.SetActive(true);
			greetingA.text = "Would you perhaps be able to help me out?";
			optionText1A.text = "Yes of course. What do you need help with?";
			optionText2A.text = "Not at this time";
		}
		if (state == State.Twee) {
			greetingGZ.SetActive(false);
			option1.SetActive(false);
			option2.SetActive(false);
			greetingGB.SetActive(true);
			option1B.SetActive(true);
			option2B.SetActive(true);
			greetingB.text = "What an attitude! I just need some help";
			optionText1B.text = "If there's something in it for me sure.";
			optionText2B.text = "No leave me be!";
		}
		if (state == State.Drie) {
			greetingGA.SetActive(false);
			option1A.SetActive(false);
			option2A.SetActive(false);
			greetingGC.SetActive(true);
			option1C.SetActive(true);
			option2C.SetActive(true);
			greetingC.text = "I want you to get me something from the dark forest.";
			optionText1C.text = "What is it?";
			optionText2C.text = "Please be fast.";
		}
		if (state == State.Vier) {
			greetingGB.SetActive(false);
			option1B.SetActive(false);
			option2B.SetActive(false);
			greetingGD.SetActive(true);
			option1D.SetActive(true);
			option2D.SetActive(true);
			greetingD.text = "I can upgrade your armor but it will be fatal to me.";
			optionText1D.text = "I don't care, I'll do it.";
			optionText2D.text = "Ok I'll do it for free.";
		}
		if (state == State.Vijf) {
			greetingGA.SetActive(false);
			option1A.SetActive(false);
			option2A.SetActive(false);
			greetingGE.SetActive(true);
			option1E.SetActive(true);
			option2E.SetActive(true);
			greetingE.text = "Ok I hope you'll come back later";
			optionText1E.text = "Bye!";
			optionText2E.text = "I'll be back soon.";
		}
		if (state == State.Zes) {
			greetingGB.SetActive(false);
			option1B.SetActive(false);
			option2B.SetActive(false);
			greetingGF.SetActive(true);
			option1F.SetActive(true);
			option2F.SetActive(true);
			greetingF.text = "Let's hope I'll see you again.";
			optionText1F.text = "Hmpf probably not.";
			optionText2F.text = "Maybe.";
		}
		if (state == State.Zeven) {
			greetingGC.SetActive(false);
			option1C.SetActive(false);
			option2C.SetActive(false);
			greetingGG.SetActive(true);
			option1G.SetActive(true);
			greetingG.text = "It's a staff with amazing powers.";
			optionText1G.text = "I'll get it for you.";
		}
		if (state == State.Acht) {
			greetingGD.SetActive(false);
			option1D.SetActive(false);
			option2D.SetActive(false);
			greetingGH.SetActive(true);
			option1H.SetActive(true);
			greetingH.text = "Ok it's a staff I need to have back.";
			optionText1H.text = "Hmm, I hope I get to kill some people.";
		}
		if (state == State.Negen) {
			greetingGC.SetActive(false);
			option1C.SetActive(false);
			greetingGC.SetActive(true);
			option1I.SetActive(true);
			greetingI.text = "It's a staff";
			optionText1I.text = "On my way!";
		}
		if (state == State.Tien) {
			greetingGD.SetActive(false);
			option1D.SetActive(false);
			option2D.SetActive(false);
			greetingGJ.SetActive(true);
			option1J.SetActive(true);
			greetingJ.text = "Ahh, hope is not lost at all, I need my staff back.";
			optionText1J.text = "Ok I'll get it.";
		}
	}
	
	public void StateEen () {
		state = State.Een;
	}
	
	public void StateTwee () {
		state = State.Twee;
	}
	
	public void StateDrie () {
		state = State.Drie;
	}
	
	public void StateVier () {
		state = State.Vier;
	}
	
	public void StateVijf () {
		state = State.Vijf;
	}
	
	public void StateZes () {
		state = State.Zes;
	}
	
	public void StateZeven () {
		state = State.Zeven;
	}
	
	public void StateAcht () {
		state = State.Acht;
	}
	
	public void StateNegen () {
		state = State.Negen;
	}
	
	public void StateTien () {
		state = State.Tien;
	}
	
	public void EndConversation () {
		greetUI.SetActive(false);
		Cursor.visible = false;
		playermanager.GetComponent<PlayerManager>().movement = 4;
		player.GetComponent<FirstPerson>().mouseSensitivity = 1;
		GameObject.Find("Main Camera").GetComponent<Detection>().enabled = true;
	}
}