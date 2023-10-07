using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEnemyBaseController : MonoBehaviour
{
    [SerializeField] private GameObject _enemyBase;
    [SerializeField] private GameObject[] _triggerEnemyBase;
    [SerializeField] private GameObject[] _enemySpawnPoints;
    private int _totalEnemyBase;
    
    public void SpawnEnemyBase(int targetBaseIndex)
    {
        if (targetBaseIndex < _triggerEnemyBase.Length)
        {
            _enemySpawnPoints[targetBaseIndex].SetActive(true);
            _triggerEnemyBase[targetBaseIndex].SetActive(false);
        }
        else
        {
            Debug.Log("No more enemy base to spawn!");
        }
    }
}
