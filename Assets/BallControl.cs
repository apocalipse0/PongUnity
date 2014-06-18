using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public float ballSpeed = 60f;
	public AudioClip myClip;

	public void Start () {
		ResetBall ();
	}

	public void OnCollisonEnter2D (Collision2D collinfo) {
		if (collinfo.collider.tag == "Player") {
			Vector2 vel = rigidbody2D.velocity;
			vel.y = vel.y/3 + collinfo.collider.rigidbody2D.velocity.y/5;
			rigidbody2D.velocity = vel;

			
		}
	}



	public IEnumerator TriggerBall(){
		yield return new WaitForSeconds (3);

		float randomNumber = Random.Range (0f, 2f);
		if (randomNumber <= 0.5) 
		{
			rigidbody2D.AddForce (new Vector2 (ballSpeed, 10f));
		}
		else{
			rigidbody2D.AddForce (new Vector2 (-ballSpeed, -10f));
		}
	}

	public void ResetBall(){
		Vector2 rigidbody = rigidbody2D.velocity;
		rigidbody.x = 0;
		rigidbody.y = 0;
		rigidbody2D.velocity = rigidbody;
		Vector2 myTransform = transform.position;
		myTransform.x = 0;
		myTransform.y = 0;
		transform.position = myTransform;
		audio.clip = myClip;
		audio.pitch = Random.Range(0.7f, 1.3f);
		audio.Play();

		StartCoroutine(TriggerBall ());

	}

}
