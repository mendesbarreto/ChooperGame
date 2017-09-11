using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public sealed class LoadLevels : MonoBehaviour {

    //L1
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

   //LISTA
    public void L1Press()
    {
        SceneManager.LoadScene("L1");
    }

    public void L2Press()
    {
        SceneManager.LoadScene("L2");
    }


}
