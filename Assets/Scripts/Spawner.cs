using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject[] spring;

	private void Start ()
	{
		SpawnObjects ();
	}

	private void SpawnObjects()
	{
		var randomIndex = Random.Range(0, 4);
		var randomPosition = new Vector3 (Random.Range(-4f,4f), transform.position.y + 3.8f, 0f);
		Instantiate (spring[randomIndex], randomPosition, Quaternion.identity);
		Invoke (nameof(SpawnObjects), 1);
	}
}
