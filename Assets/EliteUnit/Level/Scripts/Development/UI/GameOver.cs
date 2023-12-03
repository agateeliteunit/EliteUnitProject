using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Opsive.Shared.Events;


public class GameOver : MonoBehaviour
{
    private int deathPenalty = -1000;
    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        gameOverUI.gameObject.SetActive(true);
    }

    public void OnRespawn()
    {
        gameOverUI.gameObject.SetActive(false);
    }
}
