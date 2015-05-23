using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	public int buttonWidth = 120;
	public int buttonHeight = 30;

	void OnGUI()
	{		
		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (Screen.height / 2) - (buttonHeight / 2), buttonWidth, buttonHeight), "Retry!"))
		{
			Application.LoadLevel ("Main");
		}
	}
}
