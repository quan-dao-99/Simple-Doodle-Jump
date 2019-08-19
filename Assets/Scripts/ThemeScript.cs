using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeScript : MonoBehaviour {
	public static ThemeScript instance;

	private void Awake() {
		if (instance == null)
			instance = this;
		else
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);
		Debug.Log(Application.persistentDataPath + "/sound.settings");
	}
}
