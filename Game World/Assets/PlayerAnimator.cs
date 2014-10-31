using UnityEngine;
using System.Collections;

public class PlayerAnimator : MonoBehaviour {

	public Sprite[] sprites;
	public float framesPerSecond;
	private SpriteRenderer sr;

	void Start () {
		sr = renderer as SpriteRenderer;
	}
	
	void Update () {
		if (Input.GetAxis ("Horizontal") > 0
		    || Input.GetAxis ("Horizontal") < 0
		    || Input.GetAxis ("Vertical") > 0
		    || Input.GetAxis ("Vertical") < 0) {
			int i = (int)(Time.timeSinceLevelLoad * framesPerSecond);
			i = i % sprites.Length;
			sr.sprite = sprites [i];
		}
	}
}
