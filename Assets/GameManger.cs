using UnityEngine;
using System.Collections;

public class GameManger : MonoBehaviour {

	static public int playerScore1 = 0;
	static public int playerScore2 = 0;
	public Transform ball;

	public void Start(){
		ball = GameObject.FindGameObjectWithTag ("Ball").transform;
	}

	public GUISkin skin;

	static public void Score(string wallName){
		if (wallName.Equals("rightWall"))
		    playerScore2 += 1;
		    if (wallName.Equals("leftWall"))
		    playerScore1 += 1;
	}

	public void OnGUI(){
		GUI.skin = skin;
		GUI.Label (new Rect (Screen.width / 2 - 150-18, 20, 100, 100), playerScore1.ToString ());
		GUI.Label (new Rect (Screen.width / 2 + 150-18, 20, 100, 100), playerScore2.ToString ());
		if (GUI.Button (new Rect (Screen.width / 2- 60, 35, 120, 60), "RESET")) {
			playerScore1 = 0;
			playerScore2 = 0;
			ball.gameObject.SendMessage("ResetBall");
		}
	}
}
		   
