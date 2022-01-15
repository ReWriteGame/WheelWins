using UnityEngine;

public class Teleportation : MonoBehaviour
{
    [SerializeField] private Transform targetPosition;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = targetPosition.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        other.transform.position = targetPosition.position;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        other.transform.position = targetPosition.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = targetPosition.position;
    }
}
