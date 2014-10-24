using UnityEngine;
using System.Collections;

public class SpriteChange : MonoBehaviour {

	public Sprite sp1;
	public Sprite sp2;
	private SpriteRenderer srr;

	void Start () {
		srr = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)
		    || Input.GetMouseButtonDown (1)) {
			if (srr.sprite == sp1) 
				srr.sprite = sp2;
			else if (srr.sprite == sp2) 
				srr.sprite = sp1;
		}
	}
}
