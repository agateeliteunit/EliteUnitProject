using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCheckpointController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject[] _checkpoints;
    [SerializeField] private GameObject _playerSpawnPoint;
    
    private int _savedCheckpointIndex;
    private float _savedTimeLeft;
    
    private int _assaultRifleAmmo;
    private int _pistolAmmo;
    private int _granadeAmmo;
    private int _shotgunAmmo;
    
    public int assaultRifleAmmo { get { return _assaultRifleAmmo; } }
    public int pistolAmmo { get { return _pistolAmmo; } }
    public int granadeAmmo { get { return _granadeAmmo; } }
    public int shotgunAmmo { get { return _shotgunAmmo; } }
    
    void Start()
    {
        _savedCheckpointIndex = 0;
    }
    
    public void SetCheckpoint(
        int checkpointIndex,
		Vector3 checkpointPosition,
        int assaultRifleAmmo,
        int pistolAmmo, 
        int granadeAmmo,
        int shotgunAmmo,
        float timeLeft
        ) {
        for (int i = 0; i < _checkpoints.Length; i++)
        {
            Debug.Log("Checkpoint position: " + _checkpoints[i].transform.position);
            if (_savedCheckpointIndex == checkpointIndex)
            {
                Debug.Log("Checkpoint found! at index: " + i);
                
                _playerSpawnPoint.transform.position = checkpointPosition;
                
                _savedTimeLeft = timeLeft;
                _assaultRifleAmmo = assaultRifleAmmo;
                _pistolAmmo = pistolAmmo;
                _granadeAmmo = granadeAmmo;
                _shotgunAmmo = shotgunAmmo;
                
                _savedCheckpointIndex++;
                
                Debug.Log("Assault Rifle Ammo Saved: " + _assaultRifleAmmo);
                Debug.Log("Pistol Ammo Saved: " + _pistolAmmo);
                Debug.Log("Granade Ammo Saved: " + _granadeAmmo);
                Debug.Log("Shotgun Ammo Saved: " + _shotgunAmmo);
            }
        }
        
    }
    
    public void LoadCheckpoint()
    {
        _player.transform.position = _playerSpawnPoint.transform.position;
    }
    
    public int GetSavedCheckpointIndex()
    {
        return _savedCheckpointIndex;
    }
    
    public float GetSavedTimeLeft()
    {
        return _savedTimeLeft;
    }
    
}
