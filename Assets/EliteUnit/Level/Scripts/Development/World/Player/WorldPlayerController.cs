using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPlayerController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private WorldController _worldController;
    void Update()
    {
        // Movement control
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }

		if (Input.GetKey(KeyCode.F))
		{
			_worldController.TriggerFire();
		}

		if (Input.GetKeyDown(KeyCode.R))
        {
            _worldController.LoadCheckpoint();
        }

		if (Input.GetKeyDown(KeyCode.G))
		{
			_worldController.TriggerGrenade();
		}
    }
    
    
}
