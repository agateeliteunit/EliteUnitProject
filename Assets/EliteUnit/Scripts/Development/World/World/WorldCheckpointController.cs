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
    private int _savedAmmo;
    private int _savedGranades = 0;
    public void SetCheckpoint(Vector3 checkpointPosition, int currentAmmo, int currentGranades, float timeLeft)
    {
        for (int i = 0; i < _checkpoints.Length; i++)
        {
            if (_checkpoints[i].transform.position == checkpointPosition)
            {
                _playerSpawnPoint.transform.position = _checkpoints[i].transform.position;
                _checkpoints[i].SetActive(false);
                // _savedAmmo = currentAmmo;
                // _savedGranades = currentGranades;
                // _savedTimeLeft = timeLeft;
                _savedCheckpointIndex++;
                Debug.Log("Checkpoint saved! at index: " + _savedCheckpointIndex);
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
    
    public int GetSavedAmmo()
    {
        return _savedAmmo;
    }
    
    public int GetSavedGranades()
    {
        return _savedGranades;
    }
    
    public float GetSavedTimeLeft()
    {
        return _savedTimeLeft;
    }
    
}
