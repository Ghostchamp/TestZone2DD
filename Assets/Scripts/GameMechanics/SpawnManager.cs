using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> enemyPrefab = new List<GameObject>();
    public List<Transform> spawnPoints = new List<Transform>();
    private List<GameObject> enemyAlive;
    private int countOfEnemys = 3;
    

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    public void SpawnEnemies()
    {
        for (int i = 0; i < countOfEnemys; i++)
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

    private bool CheckSpawnPos(Transform spawnPos, GameObject prefab)
    {
        if (prefab.transform == spawnPos)
        {
            return false;
        }
        return true;
    }
}
