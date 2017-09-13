using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour {

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


    public static MainGame instance;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(transform.gameObject);
    }

}
