using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerFinish : MonoBehaviour
{
    [SerializeField] private WorldController _worldController;
    [SerializeField] private Canvas finishCanvas; // Reference to the UI canvas

    void Start()
    {
        finishCanvas.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _worldController.TriggerMissionFinished();
            finishCanvas.gameObject.SetActive(true);
        }
    }
}