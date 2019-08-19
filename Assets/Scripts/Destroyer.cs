using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	void OnTriggerStay2D (Collider2D other)
	{
		if (other.CompareTag("Spring"))
		{
			Destroy (other.gameObject);
		}
	}
}
