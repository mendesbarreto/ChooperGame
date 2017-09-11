using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControlers : MonoBehaviour {


    public int[] Levels 
    {
        get { return levels;}
        set { levels = value; }
    }
    [SerializeField]
    private int[] levels = new int[12];


    public string LevelsKey 
     {
        get { return levelsKey;}
    }
    [SerializeField]
    private static string levelsKey = "Levels ";

    public static LevelControlers instance;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        LoadResources();
    }



    private void LoadResources()
    {
        levels[0] = 1;


        for (int i = 0; i < 12; i++)
        {

            // PARA CADA FASE
            if (PlayerPrefs.HasKey(LevelsKey + i))
            {
                levels[i] = PlayerPrefs.GetInt(LevelsKey + i);
            }
            else
            {
                PlayerPrefs.SetInt(LevelsKey + i, levels[i]);
            }
        }
    }
}
