using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 5f;
    public Vector2 spawnRange = new Vector2(8f, 4f);

    void Start()
    {
        InvokeRepeating("SpawnCoin", 2f, spawnInterval);
    }

    void SpawnCoin()
    {
        Vector2 position = new Vector2(
            Random.Range(-spawnRange.x, spawnRange.x),
            Random.Range(-spawnRange.y, spawnRange.y)
        );

        Instantiate(coinPrefab, position, Quaternion.identity);
    }
}