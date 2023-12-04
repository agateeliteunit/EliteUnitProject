using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

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
    public AudioMixer audio;
    public TMP_Dropdown resolutionDropdown;
    Resolution[] resolutions;

    public void setReso(int resoIndex)
    {
        Resolution resolution = resolutions[resoIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void setVol(float volume)
    {
        audio.SetFloat("volume", volume);
    }

    public void ScreenMode(int screen)
    {
        if(screen == 0)
        {
            Screen.fullScreen = true;
        }

        else if(screen == 1)
        {
            Screen.fullScreen = false;
        }
    }
    
    public void Map1()
    {
        SceneManager.LoadScene("Cutscene 1");
    }

    public void Map2()
    {
        SceneManager.LoadScene("Cutscene 2");
    }

    public void Map3()
    {
        SceneManager.LoadScene("Cutscene 3");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Menu Level");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void FooterExit()
    {
        Application.Quit();
    }

    void Start()
    {
        // _missionFinishedCanvas.SetActive(false);
        resolutions = Screen.resolutions;

        List<string> options = new List<string>();

        int currentReso = 0;

        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentReso = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentReso;
        resolutionDropdown.RefreshShownValue();
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
