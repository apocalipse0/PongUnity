using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

		public float speed = 3;
		
		
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {

		if (Input.GetMouseButtonDown (0) || Input.GetMouseButton(0)) {
					Vector2 currentPosition = new Vector2 (transform.position.x, transform.position.y);
					Vector2 targetPosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);

					Vector2 v = rigidbody2D.velocity;
					v.y = speed;
					v.x = 0;

					if (targetPosition.y > Screen.height/2) {
						
						rigidbody2D.velocity = v;	
					} else {
						rigidbody2D.velocity = -v;
					}
				}
			if (Input.GetMouseButtonUp(0)){
			rigidbody2D.velocity = new Vector2(0,0);

			}

		}
}