using UnityEngine;

public class PlaySound : MonoBehaviour
{
	public AudioSource effect1;
	private void OnTriggerEnter(Collider other)
	{
	 if (other.CompareTag("Player"))
        {
          effect1.Play();
        }
	}
}