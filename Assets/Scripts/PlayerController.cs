using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    [SerializeField] private float moveForce;

    private float _move;
    private Transform _transform;
    private Rigidbody2D _rigidbody2D;
    private float _screenSizeInPixels;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = transform;
        _screenSizeInPixels = Screen.width / Screen.dpi;
    }

    private void Update()
    {
        _move = Input.GetAxis("Horizontal");
        
        if (_transform.position.x > _screenSizeInPixels)
        {
            _transform.position = new Vector2(-_screenSizeInPixels, _transform.position.y);
        }
        else if (_transform.position.x < -_screenSizeInPixels)
        {
            _transform.position = new Vector2(Screen.width / Screen.dpi, _transform.position.y);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_move * moveForce, _rigidbody2D.velocity.y);
        if (_rigidbody2D.velocity.x > maxSpeed)
        {
            _rigidbody2D.velocity = new Vector2(maxSpeed, _rigidbody2D.velocity.y);
        }
    }
}