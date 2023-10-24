using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WorldUIController : MonoBehaviour
{
    [SerializeField] private Text _timeLeftText;
    // [SerializeField] private TMP_Text _currentAmmo;
    // [SerializeField] private TMP_Text _currentHealth;
    // [SerializeField] private TMP_Text _currentGrenades;
    // [SerializeField] private GameObject _missionFinishedCanvas;
    // [SerializeField] private GameObject _GUICanvas;
    // Start is called before the first frame update
    
    private float _minute;
    private int _second;
    private string _minuteValue;
    private string _secondValue;
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Stage 1");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void FooterExit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Start()
    {
        // _missionFinishedCanvas.SetActive(false);
    }
    
    public void UpdateTimeLeft(float timeLeft)
    {
        // change time left to time format
        _minute = Mathf.Floor(timeLeft / 60);
        if (_minute < 10)
        {
            _minuteValue = "0" + Mathf.Floor(timeLeft / 60).ToString();
        }
        else
        {
            _minuteValue = Mathf.Floor(timeLeft / 60).ToString();
        }
        _second = Mathf.RoundToInt(timeLeft % 60);
        if (_second < 10)
        {
            _secondValue = "0" + _second.ToString();
        }
        else
        {
            _secondValue = _second.ToString();
        }
        _timeLeftText.text = _minuteValue + ":" + _secondValue;
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
