using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Death : MonoBehaviour {

    [SerializeField]
    private string objectTag;

    [SerializeField]
    private Canvas defeatScreen;


    private void Start()
    {
        LoadResources();
    }


    private void LoadResources()
    {
        defeatScreen.enabled = false;
        Time.timeScale = 1.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == objectTag)
        {
            Time.timeScale = 0.0f;
            defeatScreen.enabled = true;
    
        }
    }
}
