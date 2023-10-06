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
        _uiController.UpdateAmmo(_inventoryController._currentAmmo);
        _uiController.UpdateHealth(_inventoryController._currentHealth);
        _uiController.UpdateGrenades(_inventoryController._currentGrenades);
    }
    
    public void TriggerCheckpoint(Vector3 checkpointPosition)
    {
        _missionController.IncreaseTimeLeft(30);
        _checkpointController.SetCheckpoint(
            checkpointPosition,
            _inventoryController._currentAmmo, 
            _inventoryController._currentGrenades, 
            _missionController.timeLeft
            );
        _enemyBaseController.SpawnEnemyBase();
        Debug.Log("Checkpoint triggered!");
    }
    
    public void LoadCheckpoint()
    {
        _checkpointController.LoadCheckpoint();
        if (_checkpointController.GetSavedCheckpointIndex() > 0)
        {
            _inventoryController._currentAmmo = _checkpointController.GetSavedAmmo();
            _inventoryController._currentGrenades = _checkpointController.GetSavedGranades();
            _inventoryController._currentHealth = _inventoryController._initialHealth;
            _missionController.setTimeLeft(_checkpointController.GetSavedTimeLeft());
        }
        else
        {
            _inventoryController._currentAmmo = _inventoryController._initialAmmo;
            _inventoryController._currentGrenades = _inventoryController._initialGrenades;
            _inventoryController._currentHealth = _inventoryController._initialHealth;
            _missionController.setTimeLeft(_missionController.initialTimeLeft);
        }
        Debug.Log("Checkpoint loaded!");
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
        _inventoryController.DecreaseAmmo(1);
    }
    
    public void TriggerGrenade()
    {
        Debug.Log("Grenade!");
        _inventoryController.DecreaseGrenades(1);
    }
    
    public void TriggerDecreaseHP()
    {
        Debug.Log("Enemy died!");
        _inventoryController.DecreaseHealth(1);
    }
    

}
