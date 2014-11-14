using UnityEngine;
using System.Collections;

public class PlayerMoveControl : MonoBehaviour {

	public float moveSpeed;
	public float jumpSpeed;
	public AudioClip jumpSound;
	public int score = 0;

	private int counter = 2;
	private bool onGround;
	private Rigidbody2D rbody;

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Ground")
			onGround = true;
	}
	
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
		if (Input.GetKeyDown (KeyCode.Space) && counter != 0) {
			onGround = false;
			rbody.AddForce (Vector2.up * jumpSpeed);
			gameObject.audio.PlayOneShot (jumpSound);
			counter--;
		}
		if (onGround)
			counter = 2;
	}
}
