using UnityEngine;
using System.Collections;

public class incrementScore : MonoBehaviour {

	public int increment = 10;
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveControl>().score += increment;
			
			GameObject.FindGameObjectWithTag("Score").GetComponent<GUIText>().text = 
				GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveControl>().score.ToString();
		}
	}
}
