using UnityEngine;
using System.Collections;

public class LosingCheck : MonoBehaviour {
	public GUIText gameOver;

	void Start ()
	{
		gameOver = GameObject.Find("GameOver").GetComponent<GUIText> ();
		gameOver.text = "Game Over!";
		gameOver.enabled = false;
		Time.timeScale = 1;
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if (other.name == "Player")
		{
			gameOver.enabled = true;
			Time.timeScale = 0;
			gameObject.AddComponent<GameOverScript> ();
		}
	}
}
