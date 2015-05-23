using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float maxSpeed;
	public float moveForce;
	[HideInInspector]
	public float move;

	// Use this for initialization
	void Start () {
	
	}

	void Update ()
	{
		move = Input.GetAxis ("Horizontal");
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 ((move * moveForce), GetComponent<Rigidbody2D>().velocity.y);
		if (GetComponent<Rigidbody2D>().velocity.x > maxSpeed)
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
	}
}
