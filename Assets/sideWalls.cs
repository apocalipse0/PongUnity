using UnityEngine;
using System.Collections;

public class sideWalls : MonoBehaviour {
	
	public void OnTriggerEnter2D (Collider2D hitInfo) {
		if (hitInfo.name == "Ball")
		{
			string wallName = transform.name;
			GameManger.Score(wallName);
			hitInfo.gameObject.SendMessage("ResetBall");
		}
	}
}
