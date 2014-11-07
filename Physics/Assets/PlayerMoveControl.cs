using UnityEngine;
using System.Collections;

public class PlayerMoveControl : MonoBehaviour {

	public float moveSpeed;
	public float jumpSpeed;

	private Rigidbody2D rbody;

	void Start () {
		rbody = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		Vector3 tempPosition = transform.position;
		if (Input.GetAxis ("Horizontal") > 0)
			tempPosition.x += moveSpeed;
		if (Input.GetAxis ("Horizontal") < 0)
			tempPosition.x -= moveSpeed;
	
		transform.position = tempPosition;
	}

	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.Space)) 
			rbody.AddForce (Vector2.up * jumpSpeed);
	}
}
