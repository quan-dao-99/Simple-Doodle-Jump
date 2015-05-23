using UnityEngine;
using System.Collections;

public class Pausing : MonoBehaviour {
	private int pausingCount = 0;

	void Update ()
	{
		if (Input.GetButtonDown("Cancel"))
		{
			if (pausingCount % 2 == 0)
				Time.timeScale = 0;
			else
				Time.timeScale = 1;
			pausingCount++;
		}
	}
}