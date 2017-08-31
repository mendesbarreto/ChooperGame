using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Hud : MonoBehaviour {
    public Button restartButton;


    public void RestartGame()
    {
        SceneManager.LoadScene("Demo2");
    }

}
