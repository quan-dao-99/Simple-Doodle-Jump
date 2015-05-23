using UnityEngine;
using System.Collections;

public class CheckResetCollider : MonoBehaviour {
	public Transform switcher1;
	public Transform switcher2;

	void OnTriggerEnter2D ()
	{
		switcher1.GetComponent<BoxCollider2D> ().enabled = true;
		switcher2.GetComponent<BoxCollider2D> ().enabled = true;
	}
}
