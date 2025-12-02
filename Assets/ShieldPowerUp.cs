using UnityEngine;

public class ShieldPowerUp : MonoBehaviour
{
    public float shieldDuration = 5f;
    public AudioClip pickupSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (pickupSound != null)
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);

            PlayerShield playerShield = other.GetComponent<PlayerShield>();
            if (playerShield != null)
            {
                playerShield.ActivateShield(shieldDuration);
            }

            Destroy(gameObject);
        }
    }
}