using UnityEngine;
using System.Collections;

public class getCoin : MonoBehaviour {

	public AudioClip coinSound;

	void OnTriggerEnter2D (Collider2D other) {
		gameObject.audio.PlayOneShot (coinSound);
	}
}
