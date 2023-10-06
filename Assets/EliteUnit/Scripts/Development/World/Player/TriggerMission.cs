using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMission : MonoBehaviour
{
    [SerializeField] private WorldController _worldController;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MissionFinish"))
        {
            _worldController.TriggerMissionFinished();
            Debug.Log("Mission finished!");
        }
    }
}
