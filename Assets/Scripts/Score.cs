using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	int score = 0;
	public Text scoreTxt;
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y >= score)
		{
			score = (int)transform.position.y;
			scoreTxt.text = "Score: " + score;
		}
	}
}
