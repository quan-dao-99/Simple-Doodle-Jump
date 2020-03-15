using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private string springTag;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag(springTag))
        {
            Destroy(other.gameObject);
        }
    }
}