using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.Shared.Events;

public class WorldMissionController : MonoBehaviour
{
    public float timeLeft;
    public float initialTimeLeft;

    public int totalPoints;

    private int killPoints = 50;
    private int headShot = 100;
    private int remainingHPPoints = 50;
    private int deathPenalty = -1000;
    private int pointsPerSecond = 100;

    [SerializeField] protected GameObject m_Character;

    void Start()
    {
        initialTimeLeft = timeLeft;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            // Uncomment the line below if you want to stop the time when it reaches 0
            // timeLeft = 0;
            MissionFailed();
        }
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
        timeLeft = Mathf.Max(timeLeft, 0); // Ensure timeLeft is not negative
        totalPoints = CalculatePoints();
        Time.timeScale = 0;
    }

    public int CalculatePoints()
    {
        int points = 0;

        if (headShot > 0)
        {
            points += headShot;
        }

        if (killPoints > 0)
        {
            points += killPoints;
        }

        if (remainingHPPoints > 0)
        {
            points += remainingHPPoints;
        }

        if (timeLeft <= 0)
        {
            points += deathPenalty;
        }
        else
        {
            points += (int)(pointsPerSecond * timeLeft);
        }

        return points;
    }
}
