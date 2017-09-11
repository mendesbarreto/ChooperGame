using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Win : MonoBehaviour {

    public GameObject Player;

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


    private void Start()
    {
        WinScreen.enabled = false;
        continueButton = continueButton.GetComponent<Button>();
        restartButton = restartButton.GetComponent<Button>();
        Time.timeScale = 1.0f;

    }


     void Update () {
	
        if (Player.transform.position.x >=WinPosition)
        {
            if (LevelControlers.instance._levels[LevelNumber + 1] == 0 && LevelNumber < 12)
            {
                LevelControlers.instance._levels[LevelNumber + 1] = 1;
                PlayerPrefs.SetInt("Levels " + (LevelNumber + 1), LevelControlers.instance._levels[LevelNumber + 1]);
            }
            Time.timeScale = 0.0f;
            menuButton.enabled = false;
            WinScreen.enabled = true;
        }	

	}


    public void ContinueGame()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void RestartGame()
    {
        //SceneManager.LoadScene("DemoNoturne");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
