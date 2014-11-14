using UnityEngine;
using System.Collections;

public class NpcAnimator : MonoBehaviour {
	
	public Sprite[] sprites;
	public float framesPerSecond;
	private SpriteRenderer sr;

	void Start () {
		sr = renderer as SpriteRenderer;
	}
	
	void Update () {
		int i = (int)(Time.timeSinceLevelLoad * framesPerSecond);
		i = i % sprites.Length;
		sr.sprite = sprites [i];
	}
}
