using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
	public Transform otherSwitcher;

	void OnTriggerStay2D (Collider2D player)
	{
		if (player.name == "Player")
		{
			otherSwitcher.GetComponent<BoxCollider2D>().enabled = false;
			player.transform.position = new Vector3 (otherSwitcher.transform.position.x, player.transform.position.y, player.transform.position.z);
			//player.GetComponent<Rigidbody2D>().velocity = new Vector2 (player.GetComponent<Rigidbody2D>().velocity.x,player.GetComponent<Rigidbody2D>().velocity.y);
		}
	}	
}
