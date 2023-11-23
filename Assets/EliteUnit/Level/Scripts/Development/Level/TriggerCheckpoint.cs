using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheckpoint : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private WorldController _worldController;
    [SerializeField] private int _checkpointIndex;

	private Vector3 checkpointPosition;

	void Start()
    {
        checkpointPosition = transform.position;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _worldController.TriggerCheckpoint(_checkpointIndex ,checkpointPosition);
            Debug.Log("Checkpoint triggered! at position: " + other.transform.position + " index: " + _checkpointIndex + " checkpoint position: " + checkpointPosition);
            // set checkpoint to false
            gameObject.SetActive(false);
        }
    }
}
