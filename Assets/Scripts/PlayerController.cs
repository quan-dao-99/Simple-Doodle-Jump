using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    [SerializeField] private float moveForce;
    [SerializeField] private float telePoint = 5f;

    private float _move;

    private Vector3 position
    {
        get => transform.position;
        set => transform.position = value;
    }

    private void Update()
    {
        _move = Input.acceleration.x;

        var targetMove = Mathf.Clamp(_move * moveForce * Time.deltaTime, -maxSpeed, maxSpeed);
        position += new Vector3(targetMove,  0f, 0f);
        
        if (position.x > telePoint)
        {
            position = new Vector2(-telePoint, position.y);
        }
        else if (position.x < -telePoint)
        {
            position = new Vector2(telePoint, position.y);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(-telePoint, 0f), new Vector3(telePoint, 0f));
    }
}