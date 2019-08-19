using UnityEngine;
using System.Collections;

public class LosingCheck : MonoBehaviour {
	private UIManager UIManager;

	void Awake ()
	{
		UIManager = FindObjectOfType<UIManager>();
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			UIManager.ShowLoseMenu();
		}
	}
}
