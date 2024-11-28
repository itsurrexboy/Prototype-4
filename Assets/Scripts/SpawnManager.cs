using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    float randomRange = 9f;
    public int enemyCount;
    void Start()
    {
        
    }
    private void Update() {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        
        if(enemyCount == 0){
        SpawnEnemyWave(2);
        }
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPos()
    {
        float spwanPosX = Random.Range(-randomRange, randomRange);
        float spwanPosZ = Random.Range(-randomRange, randomRange);

        Vector3 randomPos = new Vector3(spwanPosX, 0, spwanPosZ);
        return randomPos;
    }

}
