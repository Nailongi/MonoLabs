using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 5f;
    private float spawnPosY = -1.5f;
    private float spawnDelay = 1f;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), spawnDelay, spawnInterval);
    }


    private void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector2 spawnPos = new Vector2(spawnRangeX, spawnPosY);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
