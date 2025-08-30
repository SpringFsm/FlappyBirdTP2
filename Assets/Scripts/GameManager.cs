using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startText;
    public GameObject endText;
    public GameObject skinChoose;
    
    public bool gameOver = false;

    public Text scoreNb;
    public int score = 0;

    public Restart restart;
    
    private void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.timeScale == 0)
        {
            startText.SetActive(false);
            skinChoose.SetActive(false);

            Time.timeScale = 1;
        }

        if (gameOver)
        {
            endText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                restart.RestartGame();
            }
        }
        
        scoreNb.text = "" + score;
    }

    public void EndGame()
    {
        gameOver = true;
    }
}