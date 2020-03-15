using UnityEngine;

public class CameraFollower : MonoBehaviour {
	[SerializeField] private Transform player;
	[SerializeField] private float verticalOffset;

	private Transform _transform;
	
	private void Awake()
	{
		_transform = transform;
	}

	// Update is called once per frame
	private void Update () {
		_transform.position = new Vector3 (transform.position.x, player.position.y + verticalOffset, _transform.position.z);
	}
}
