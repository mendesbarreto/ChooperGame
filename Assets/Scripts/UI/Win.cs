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



    public Button continueButton;
    public Button restartButton;


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
            Time.timeScale = 0.0f;
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
