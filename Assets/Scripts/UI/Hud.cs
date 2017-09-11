using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Hud : MonoBehaviour {
    public Button Menu
    {
        get { return menu; }
        set { menu = value; }
    }
    [SerializeField]
    private Button menu;



    public void MenuPress()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
