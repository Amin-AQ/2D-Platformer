using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealthPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Heal only if colliding with player
        if (collision.tag == "Player")
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            playerHealth.ReceiveHealing(playerHealth.maximumHealth);
            Destroy(this.gameObject);
        }
    }
}
