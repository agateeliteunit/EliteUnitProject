using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Opsive.Shared.Events;

public class UIGameOver : MonoBehaviour
{
    public GameOver gameOver;
    public GameObject enemyPoint;
    public GameObject timePoint;
    private int killPoints = 50;
    private int headShot = 100;
    private int remainingHPPoints = 50;
    private int deathPenalty = -1000;
    private int pointsPerSecond = 100;

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Awake()
    {
        EventHandler.RegisterEvent(gameObject, "OnRespawn", OnRespawn);
    }

    /// <summary>
    /// The object has respawned.
    /// </summary>
    public void OnRespawn()
    {
        Debug.Log(name + " Respawned.");
        gameOver.gameOverUI.SetActive(false);
    }

    /// <summary>
    /// The GameObject has been destroyed.
    /// </summary>
    public void OnDestroy()
    {
        EventHandler.UnregisterEvent(gameObject, "OnRespawn", OnRespawn);
    }

    public int CalculatePoints(bool isHeadShot, int remainingTime, int remainingHP, bool isDeath)
    {
        int totalPoints = 0;

        if (isDeath)
        {
            totalPoints += deathPenalty;
        }
        else
        {
            WorldMissionController worldMissionController = timePoint.GetComponent<WorldMissionController>();

            if (worldMissionController != null)
            {
                Debug.Log("Time Left: " + worldMissionController.timeLeft);

                int timeRemainingPoints = Mathf.Max(0, (int)(worldMissionController.timeLeft - remainingTime) * pointsPerSecond);

                Debug.Log("Time Remaining Points: " + timeRemainingPoints);

                totalPoints += timeRemainingPoints;
            }
            else
            {
                Debug.LogError("WorldMissionController is not assigned to timePoint.");
            }

            totalPoints += remainingHP * remainingHPPoints;

            if (isHeadShot)
            {
                totalPoints += killPoints * headShot;
            }
            else
            {
                totalPoints += killPoints;
            }
        }

        Debug.Log("Total Points: " + totalPoints);

        return totalPoints;
    }
}
