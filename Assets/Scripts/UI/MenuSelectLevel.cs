using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuSelectLevel : MonoBehaviour {

    public Button Menu
    {
        get { return menu; }
        set { menu = value; }
    }
    [SerializeField]
    private Button menu;

    private void Start()
    {
        LoadResources();

        
    }


    private void LoadResources()
    {
        Time.timeScale = 1.0f;
    }


    public void MenuPress()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
