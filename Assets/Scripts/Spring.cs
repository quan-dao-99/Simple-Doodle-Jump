using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {
	public float springForce;

	void OnTriggerEnter2D (Collider2D player)
	{
		if (player.name != "Destroyer" && player.name != "Check Reset")
		{
			player.GetComponent<Rigidbody2D> ().velocity = new Vector3 (player.GetComponent<Rigidbody2D>().velocity.x, 0);
			player.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, springForce));
		}
	}
}
