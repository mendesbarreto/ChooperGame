using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControlers : MonoBehaviour {

    public int[] _levels = new int[12];


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
        _levels[0] = 1;


        for (int i = 0; i < 12; i++)
        {

            // PARA CADA FASE
            if (PlayerPrefs.HasKey("Levels " + i))
            {
                _levels[i] = PlayerPrefs.GetInt("Levels " + i);
            }
            else
            {
                PlayerPrefs.SetInt("Levels " + i, _levels[i]);
            }
        }
    }
}
