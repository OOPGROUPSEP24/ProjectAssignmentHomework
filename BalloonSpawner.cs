using System.Collections;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public GameObject balloonPrefab;  // Reference to the balloon prefab
    public int rows = 4;
    public int columns = 6;
    public float spacing = 1.5f;
    public Vector2 spawnStartPos = new Vector2(-5f, 4f);
    public float minSpawnDelay = 0.5f;  // Minimum delay between spawns
    public float maxSpawnDelay = 1.5f;  // Maximum delay between spawns

    void Start()
    {
        StartCoroutine(SpawnBalloonsWithDelay());
    }

    IEnumerator SpawnBalloonsWithDelay()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Vector2 spawnPos = spawnStartPos + new Vector2(col * spacing, -row * spacing);
                Instantiate(balloonPrefab, spawnPos, Quaternion.identity);

                // Wait for a random delay before spawning the next balloon
                float delay = Random.Range(minSpawnDelay, maxSpawnDelay);
                yield return new WaitForSeconds(delay);
            }
        }
    }
}
