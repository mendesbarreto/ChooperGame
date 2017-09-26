using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public sealed class MainMenu : MonoBehaviour {

    [SerializeField]
    private GameObject codeScreen;

    [SerializeField]
    public Image imgLock;


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

    private const string NameSceneSelectLevel = "SelectLevel";

    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        Time.timeScale = 1.0f;

        if (MainGame.instance.GameStats == 1)
        {
            imgLock.enabled = false;
            play.enabled = true;
        }
        else
        {
            imgLock.enabled = true;
            play.enabled = false;
        }

    }

    private void Update()
    {
        if (codeScreen.activeInHierarchy == false)
        {
            quit.enabled = true;

            code.enabled = true;

            VerifyUnlock();
        }
    }

    private void VerifyUnlock()
    {
        if (MainGame.instance.GameStats == 1)
        {
            imgLock.enabled = false;
            Play.enabled = true;
        }
    }

    public void PlayPress()
    {
        SceneManager.LoadScene(NameSceneSelectLevel);
    }

    public void CodePress()
    {
        codeScreen.SetActive(true);
        quit.enabled = false;
        code.enabled = false;
        play.enabled = false;
    }

    public void QuitPress()
    {
        Application.Quit();
    }
}
