using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.Shared.Events;

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
	
	public void MissionFailed()
	{
		Time.timeScale = 0;
	}

    public void MissionFinished()
    {
        Time.timeScale = 0;
    }
    
}
