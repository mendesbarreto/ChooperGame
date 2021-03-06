﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public sealed class Win : MonoBehaviour {

    [SerializeField]
    private string objectTag;

    private GameObject objPlayer;

    [SerializeField]
    private Canvas WinScreen;

    [SerializeField]
    private float WinPosition;

    [SerializeField]
    private int LevelNumber;

    public Button ContinueButton
    {
        get { return continueButton; }
        set { continueButton = value; }
    }
    [SerializeField]
    private Button continueButton;

    public Button RestartButton
    {
        get { return restartButton; }
        set { restartButton = value; }
    }
    [SerializeField]
    private Button restartButton;

    public Button MenuButton
    {
        get { return menuButton; }
        set { menuButton = value; }
    }
    [SerializeField]
    private Button menuButton;

    private const int levelNumber = 10;

    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        WinScreen.enabled = false;
        continueButton = continueButton.GetComponent<Button>();
        restartButton = restartButton.GetComponent<Button>();
        objPlayer = GameObject.FindWithTag(objectTag);
       
    }

     private void Update ()
    {
        VerifyPlayerPosition();
	}

    private void VerifyPlayerPosition()
    {
        if (objPlayer.transform.position.x >= WinPosition)
        {
            WhenPlayerWin();
        }
    }

    private void WhenPlayerWin()
    {
        if (LevelControlers.instance.Levels[LevelNumber + 1] == 0 && LevelNumber < levelNumber)
        {
            LevelControlers.instance.Levels[LevelNumber + 1] = 1;
            PlayerPrefs.SetInt(LevelControlers.instance.LevelsKey + (LevelNumber + 1), LevelControlers.instance.Levels[LevelNumber + 1]);
        }
        Time.timeScale = 0.0f;
        menuButton.enabled = false;
        WinScreen.enabled = true;


    }

    public void ContinueGame()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
