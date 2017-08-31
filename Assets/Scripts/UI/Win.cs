using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Win : MonoBehaviour {

    public GameObject Player;

    [SerializeField]
    private Canvas WinScreen;

    public Button dayTimeButton;
    public Button nocturneButton;


    private void Start()
    {
        WinScreen.enabled = false;
        dayTimeButton = dayTimeButton.GetComponent<Button>();
        nocturneButton = nocturneButton.GetComponent<Button>();
        Time.timeScale = 1.0f;

    }


     void Update () {
	
        if (Player.transform.position.x >= 51.50f)
        {
            Time.timeScale = 0.0f;
            WinScreen.enabled = true;
        }	

	}

          
       



    public void DaytimeGame()
    {
        SceneManager.LoadScene("Demo2");
    }

    public void NocturneGame()
    {
        SceneManager.LoadScene("DemoNoturne");
    }

}
