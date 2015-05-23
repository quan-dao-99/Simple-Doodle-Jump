﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject spring;

	void Start ()
	{
		SpawnObjects ();
	}

	void SpawnObjects()
	{
		Vector3 randomPosition = new Vector3 (Random.Range(-13,13), transform.position.y + 3.8f, 0f);
		Instantiate (spring, randomPosition, Quaternion.identity);
		Invoke ("SpawnObjects", 0.5f);
	}
}
