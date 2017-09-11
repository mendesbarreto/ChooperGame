using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class UnlockLevels : MonoBehaviour {
    [SerializeField]
    private int CurrentLevel;

    private void Start()
    {
        VerifyLevel();
    }

    private void VerifyLevel()
    {
        if (LevelControlers.instance.Levels[CurrentLevel] == 1)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Button>().interactable = true;
        }
    }

}
