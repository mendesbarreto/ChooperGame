using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public sealed class LoadLevels : MonoBehaviour {

    /*
    public Button Level1
    {
        get { return level1; }
        set { level1 = value; }
    }
    [SerializeField]
    private Button level1;
    
    //L2
    public Button Level2
    {
        get { return level2; }
        set { level2 = value; }
    }
    [SerializeField]
    private Button level2;
    */
    //BUTTONS
    public Button[] Level
    {
        get { return level; }
        set { level = value; }
    }
    [SerializeField]
    private Button[] level = new Button[12];



    //LISTA
    public void L1Press()
    {
        SceneManager.LoadScene("L1");
    }

    public void L2Press()
    {
        SceneManager.LoadScene("L2");
    }

    public void L3Press()
    {
        SceneManager.LoadScene("L3");
    }
    public void L4Press()
    {
        SceneManager.LoadScene("L4");
    }
    public void L5Press()
    {
        SceneManager.LoadScene("L5");
    }
    public void L6Press()
    {
        SceneManager.LoadScene("L6");
    }
    public void L7Press()
    {
        SceneManager.LoadScene("L7");
    }
    public void L8Press()
    {
        SceneManager.LoadScene("L8");
    }
    public void L9Press()
    {
        SceneManager.LoadScene("L9");
    }
    public void L10Press()
    {
        SceneManager.LoadScene("L10");
    }
    public void L11Press()
    {
        SceneManager.LoadScene("L11");
    }
    public void L12Press()
    {
        SceneManager.LoadScene("L12");
    }

}
