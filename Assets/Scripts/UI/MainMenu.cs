﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public sealed class MainMenu : MonoBehaviour {

  

    public Button Play
    {
        get { return play; }
        set { play = value; }
    }
    [SerializeField]
    private Button play;


    public Button Code
    {
        get { return code; }
        set { code = value; }
    }
    [SerializeField]
    private Button code;

    public Button Quit
    {
        get { return quit; }
        set { quit = value; }
    }
    [SerializeField]
    private Button quit;



    public void PlayPress()
    {
        SceneManager.LoadScene("SelectLevel");
    }


    public void CodePress()
    {
    }


    public void QuitPress()
    {
        Application.Quit();
    }

}