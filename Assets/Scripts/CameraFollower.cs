using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour {
	public GameObject player;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, player.transform.position.y + 2, transform.position.z);
	}
}
