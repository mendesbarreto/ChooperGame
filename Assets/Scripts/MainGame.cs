using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{

    public int CurrentObject
    {
        get { return currentObject; }
        set { currentObject = value; }
    }
    private int currentObject;

    public int[] PlayerList
    {
        get { return playerList; }
        set { playerList = value; }
    }
    [SerializeField]
    private int[] playerList = new int[3];

    public int GameStats
    {
        get { return gameStats; }
        set { gameStats = value; }
    }
    private int gameStats;

    public string TxtGameStats
        {
        get { return txtGameStats; }
        set { txtGameStats = value; }
        }
    [SerializeField]
    private string txtGameStats = "gameStats";

    public static MainGame instance;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Start()
    {
       
        LoadResources();
    }

    private void LoadResources()
    {
        
        if (PlayerPrefs.HasKey(txtGameStats))
        {
            gameStats = PlayerPrefs.GetInt(txtGameStats);
        }
        else
        {
            PlayerPrefs.SetInt(txtGameStats, gameStats);
        }
    }

    private void Update()
    {
        Unlock();
    }

    private void Unlock()
    {
        if (gameStats == 1)
        {
            PlayerPrefs.SetInt(txtGameStats, gameStats);
        }
    }

}
