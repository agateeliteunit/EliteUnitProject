using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinish : MonoBehaviour
{
    [SerializeField] private WorldController _worldController;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _worldController.TriggerMissionFinished();
        }
    }
    
}
