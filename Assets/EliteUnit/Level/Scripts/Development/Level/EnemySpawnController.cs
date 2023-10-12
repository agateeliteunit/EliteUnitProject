using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {   
        Spawn(enemies, spawnPoints);
    }
    
    public void Spawn(GameObject[] enemies, GameObject[] spawnPoints) {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int enemyIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[enemyIndex], spawnPoints[spawnPointIndex].transform.position, spawnPoints[spawnPointIndex].transform.rotation);
    }
}
