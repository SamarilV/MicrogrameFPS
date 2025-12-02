using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    private bool isShieldActive = false;
    private float shieldTimer = 0f;

    public GameObject shieldVisual;
    public AudioClip shieldEndSound;

    void Update()
    {
        if (isShieldActive)
        {
            shieldTimer -= Time.deltaTime;
            if (shieldTimer <= 0f)
            {
                DeactivateShield();
            }
        }
    }

    public void ActivateShield(float duration)
    {
        isShieldActive = true;
        shieldTimer = duration;

        if (shieldVisual != null)
            shieldVisual.SetActive(true);
    }

    private void DeactivateShield()
    {
        isShieldActive = false;

        if (shieldVisual != null)
            shieldVisual.SetActive(false);

        if (shieldEndSound != null)
            AudioSource.PlayClipAtPoint(shieldEndSound, transform.position);
    }

    public bool IsShieldActive()
    {
        return isShieldActive;
    }
}