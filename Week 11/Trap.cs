
using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject objectToAppear;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.health -= 10;

            if (objectToAppear != null)
            {
                objectToAppear.SetActive(true);
            }
        }
    }
}
