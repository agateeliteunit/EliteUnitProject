using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Add the scene names you want to load for Play and Options here
    public string playSceneName = "GameplayScene";
    public string optionsSceneName = "OptionsScene";

    public void PlayButton()
    {
        // Load the Play scene
        SceneManager.LoadScene(playSceneName);
    }

    public void OptionsButton()
    {
        // Load the Options scene
        SceneManager.LoadScene(optionsSceneName);
    }

    public void QuitButton()
    {
        // Quit the application (only works in standalone builds)
        Application.Quit();
    }
}