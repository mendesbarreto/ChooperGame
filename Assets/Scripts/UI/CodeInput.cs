using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CodeInput : MonoBehaviour {

    [SerializeField]
    private GameObject codeScreen;

    public Button Submit
    {
        get { return submit; }
        set { submit = value; }
    }
    [SerializeField]
    private Button submit;

    public Button Back
    {
        get { return back; }
        set { back = value; }
    }
    [SerializeField]
    private Button back;

    public InputField Code
    {
        get { return code; }
        set { code = value; }
    }
    [SerializeField]
    private InputField code;

    public Text TxtIncorreto
    {
        get { return txtIncorreto; }
        set { txtIncorreto = value; }
    }
    [SerializeField]
    private Text txtIncorreto;

    private const string unlockCode = "xj917b2t8";


    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        codeScreen.SetActive(false);
       
    }

    public void SubmitPress()
    {
        if (code.text == "reset")
        {
            MainGame.instance.GameStats = 0;
            PlayerPrefs.SetInt(MainGame.instance.TxtGameStats, MainGame.instance.GameStats);
            PlayerPrefs.DeleteAll();
            txtIncorreto.text = "RESET - ESTADO: " + MainGame.instance.GameStats;

        }
        else if (code.text == unlockCode)
        {
            MainGame.instance.GameStats = 1;
            code.text = "";
            txtIncorreto.text = "";
            codeScreen.SetActive(false);

        }
        else
        {
            txtIncorreto.text = "CODIGO INCORRETO";
        }
    }

    public void BackPress()
    {
        codeScreen.SetActive(false);
        code.text = "";
        txtIncorreto.text = "";
    }
}
