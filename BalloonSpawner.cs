using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public GameObject balloonpink;   // Assign in the Inspector
    public GameObject balloonwhite;  // Assign in the Inspector
    public GameObject balloonpurple; // Assign in the Inspector

    public int balloonCount = 50; // Number of balloons to spawn per color
    public float spawnRangeX = 8f; // Horizontal range for spawning balloons
    public float minSpawnY = -4f;  // Minimum Y position for spawning
    public float maxSpawnY = -6f;  // Maximum Y position for spawning

    public float minSpawnDelay = 0.1f;  // Minimum delay between spawns
    public float maxSpawnDelay = 0.5f;  // Maximum delay between spawns

    void Start()
    {
        // Start spawning balloons
        StartCoroutine(SpawnBalloonWave(balloonpink, balloonCount));
        StartCoroutine(SpawnBalloonWave(balloonwhite, balloonCount));
        StartCoroutine(SpawnBalloonWave(balloonpurple, balloonCount));
    }

    IEnumerator SpawnBalloonWave(GameObject balloonPrefab, int count)
    {
        for (int i = 0; i < count; i++)
        {
            // Generate random position for each balloon
            Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(minSpawnY, maxSpawnY));

            // Instantiate balloon at the random position
            Instantiate(balloonPrefab, spawnPos, Quaternion.identity);

            // Wait for a random delay before spawning the next balloon
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
        }
    }
}
