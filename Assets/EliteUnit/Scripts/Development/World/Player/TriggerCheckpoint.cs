using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheckpoint : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private WorldController _worldController;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            _worldController.TriggerCheckpoint(other.transform.position);
        }
    }
}
