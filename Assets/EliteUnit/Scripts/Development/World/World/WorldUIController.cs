using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WorldUIController : MonoBehaviour
{
    // [SerializeField] private TMP_Text _timeLeftText;
    // [SerializeField] private TMP_Text _currentAmmo;
    // [SerializeField] private TMP_Text _currentHealth;
    // [SerializeField] private TMP_Text _currentGrenades;
    // [SerializeField] private GameObject _missionFinishedCanvas;
    // [SerializeField] private GameObject _GUICanvas;
    // Start is called before the first frame update
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Stage 1");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    void Start()
    {
        // _missionFinishedCanvas.SetActive(false);
    }
    
    public void UpdateTimeLeft(float timeLeft)
    {
        // _timeLeftText.text = "Time left: " + Mathf.Round(timeLeft);
    }
    
	public void UpdateAmmo(int ammo)
    {
        // _currentAmmo.text = ammo.ToString();
    }

	public void UpdateHealth(int health)
    {
        // _currentHealth.text = "Health: " + health;
    }

	public void UpdateGrenades(int grenades)
    {
        // _currentGrenades.text = grenades.ToString();	
    }
    
    public void MissionFinished(int timeLeft)
    {
        
        // _missionFinishedCanvas.SetActive(true);
        // _GUICanvas.SetActive(false);
    }
}
