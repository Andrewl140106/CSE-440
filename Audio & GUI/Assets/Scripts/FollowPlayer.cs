using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public GameObject player;
	private float distFromPlayer = 1.5f;
	
	void Update () {
		this.gameObject.transform.position = new Vector3 (
			player.gameObject.transform.position.x + distFromPlayer,
			this.gameObject.transform.position.y,
			this.gameObject.transform.position.z );
	}
}
