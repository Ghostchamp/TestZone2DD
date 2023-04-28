using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> enemyPrefab = new List<GameObject>();
    public List<Transform> spawnPoints = new List<Transform>();
    private int countOfEnemys = 3;
    private int needToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    private void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length < 1)
        {
            SpawnEnemies();
        }
    }

    public void SpawnEnemies()
    {
        needToSpawn = countOfEnemys - CheckAlivesEnemies();
        for (int i = 0; i < needToSpawn; i++)
        {
            Transform spawnPoint = GetRandomSpawnPoint();
            var prefab = enemyPrefab[Random.Range(0, enemyPrefab.Count)];
            SpawnEnemy(spawnPoint, prefab);
        }

    }

    private Transform GetRandomSpawnPoint()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Count)];
    }

    private GameObject SpawnEnemy(Transform spawnPoint, GameObject prefab)
    {
        
        return Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }

    private int CheckAlivesEnemies()
    {

        return GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

}
