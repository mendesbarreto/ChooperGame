using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public sealed class DefeatScreen : MonoBehaviour {

    public Button Menu
    {
        get { return menu; }
        set { menu = value; }
    }
    [SerializeField]
    private Button menu;

    public Button RestartButton
    {
        get { return restartButton; }
        set { restartButton = value; }
    }
    [SerializeField]
    private Button restartButton;

    public void MenuPress()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
