using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMissionController : MonoBehaviour
{
    [SerializeField] public float timeLeft;

	public float initialTimeLeft;

	void Start() {
		initialTimeLeft = timeLeft;
	}

    void Update()
    {
        timeLeft -= Time.deltaTime;
    }
    
    public void IncreaseTimeLeft(float time)
    {
        timeLeft += time;
    }

	public void setTimeLeft(float time) 
	{
		timeLeft = time;
	}

    public void MissionFinished()
    {
        Time.timeScale = 0;
    }
    
}
