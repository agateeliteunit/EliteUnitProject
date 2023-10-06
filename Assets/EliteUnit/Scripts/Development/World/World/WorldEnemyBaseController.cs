using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEnemyBaseController : MonoBehaviour
{
    [SerializeField] private GameObject _enemyBase;
    [SerializeField] private GameObject _firstEnemyBaseSpawnPoint;
    [SerializeField] private GameObject[] _enemySpawnPoints;
    private int _totalEnemyBase;
    private int _currentEnemyBaseIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        _totalEnemyBase = _enemySpawnPoints.Length;
        Instantiate(_enemyBase, _firstEnemyBaseSpawnPoint.transform.position, Quaternion.identity);
    }

    public void SpawnEnemyBase()
    {
        if (_totalEnemyBase > 0)
        {
            Instantiate(_enemyBase, _enemySpawnPoints[_currentEnemyBaseIndex].transform.position, Quaternion.identity);
            _currentEnemyBaseIndex++;
            _totalEnemyBase--;
        }
        else
        {
            Debug.Log("No more enemy base to spawn!");
        }
    }
}
