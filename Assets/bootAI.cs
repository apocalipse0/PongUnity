using UnityEngine;
using System.Collections;

public class bootAI : MonoBehaviour {

	public float prevLoc;
	public Transform ball;
	public float speed = 3;
	private Vector2 movingSpeed = new Vector2(0, 3);
	
	public void Start(){
		ball = GameObject.FindGameObjectWithTag ("Ball").transform;
	}



	// Update is called once per frame
	void Update () {
		float curVel = ball.transform.position.y - prevLoc;
		if(curVel > 0)
		{
			rigidbody2D.velocity = movingSpeed;	
		}
		else {
			rigidbody2D.velocity = - movingSpeed;
		}
		prevLoc = ball.transform.position.y;
	}
}
