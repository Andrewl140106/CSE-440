using UnityEngine;
using System.Collections;

public class SpriteMove : MonoBehaviour {

	public float moveSpeed = 0.05f;

	void Start () {
		//
	}
	
	void Update () {
		Vector3 tempPosition = transform.position;
		if (Input.GetAxis ("Horizontal") > 0) 
			tempPosition.x += moveSpeed;
		if (Input.GetAxis ("Horizontal") < 0)
			tempPosition.x -= moveSpeed;
		if (Input.GetAxis ("Vertical") > 0) 
			tempPosition.y += moveSpeed;
		if (Input.GetAxis ("Vertical") < 0)
			tempPosition.y -= moveSpeed;

		transform.position = tempPosition; 
	}
}
