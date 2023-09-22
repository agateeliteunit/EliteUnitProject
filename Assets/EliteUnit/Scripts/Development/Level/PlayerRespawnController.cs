using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawnController : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] person;

    // Start is called before the first frame update
    void Start()
    {   
        Spawn(person, spawnPoints);
    }
    
    public void Spawn(GameObject[] person, GameObject[] spawnPoints) {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int personIndex = Random.Range(0, person.Length);
        Instantiate(person[personIndex], spawnPoints[spawnPointIndex].transform.position, spawnPoints[spawnPointIndex].transform.rotation);
    }
}
