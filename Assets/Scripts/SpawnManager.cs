using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 5f;
    private float spawnPosY = -1.5f;
    private float spawnDelay = 1f;
    private float spawnInterval = 1.8f;


    private float[] beeSpawnPosYArray = new float[] {-0.3f, 0.9f};
    private float beeSpawnPosY;


    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), spawnDelay, spawnInterval);
    }


    private void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        if (enemyIndex==0)
        {
            Vector2 spawnPos = new Vector2(spawnRangeX, spawnPosY);
            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        }

        else if (enemyIndex==1)
        {
            beeSpawnPosY = beeSpawnPosYArray[Random.Range(0, beeSpawnPosYArray.Length)];
            Vector2 spawnPos = new Vector2(spawnRangeX, beeSpawnPosY);
            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        }              
    }
}
