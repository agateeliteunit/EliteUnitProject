using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawner : MonoBehaviour
{
    [SerializeField] private WorldController _worldController;
    [SerializeField] private int _targetBaseIndex;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _worldController.TriggerEnemyBase(_targetBaseIndex);
        }
    }
}
