using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
	
    [SerializeField] private WorldCheckpointController _checkpointController;
    [SerializeField] private WorldInventoryController _inventoryController;
    [SerializeField] private WorldMissionController _missionController;
    [SerializeField] private WorldEnemyBaseController _enemyBaseController;
    [SerializeField] private WorldUIController _uiController;

    void Update()
    {
        _uiController.UpdateTimeLeft((int)_missionController.timeLeft);
        if (_missionController.timeLeft < 0)
        {
            TriggerMissionFailed();
        }

    }
    
    public void TriggerCheckpoint(int checkpointIndex, Vector3 checkpointPosition)
    {
        _missionController.IncreaseTimeLeft(30);
        _checkpointController.SetCheckpoint(
            checkpointIndex,
			checkpointPosition,
			_inventoryController.currentRifleAmmo,
			_inventoryController.currentPistolAmmo,
			_inventoryController.currentGrenadeAmmo,
			_inventoryController.currentShotgunAmmo,
            _missionController.timeLeft
            );
        Debug.Log("Checkpoint triggered!");
    }
    
    public void TriggerEnemyBase(int targetBaseIndex)
    {
        _enemyBaseController.SpawnEnemyBase(targetBaseIndex);
        Debug.Log("Enemy base triggered!");
    }
    
    public void LoadCheckpoint()
    {
        _checkpointController.LoadCheckpoint();
        if (_checkpointController.GetSavedCheckpointIndex() > 0)
        {
            _missionController.setTimeLeft(_checkpointController.GetSavedTimeLeft());
        }
        else
        {
            _missionController.setTimeLeft(_missionController.initialTimeLeft);
        }
        Debug.Log("Checkpoint loaded!");
    }

    public void TriggerMissionFailed()
    {   
        // _missionController.MissionFinished();
        Debug.Log("Mission failed!");
    }
    
    public void TriggerMissionFinished()
    {
        _missionController.MissionFinished();
        _uiController.MissionFinished((int)_missionController.timeLeft);
        Debug.Log("Mission finished!");
    }
    
    public void TriggerPlayerDeath()
    {
        Debug.Log("Player died!");
    }
    
    public void TriggerFire()
    {
        Debug.Log("Fire!");
    }
    
    public void TriggerGrenade()
    {
        Debug.Log("Grenade!");
    }
    
    public void TriggerDecreaseHP()
    {
        Debug.Log("Enemy died!");
    }
    

}
