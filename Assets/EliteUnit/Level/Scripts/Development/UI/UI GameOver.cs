using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Opsive.Shared.Events;

public class UIGameOver : MonoBehaviour
{
    public GameOver gameOver;

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
}
