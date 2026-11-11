
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.Heal(10);
            Destroy(gameObject);
        }
    }
}
