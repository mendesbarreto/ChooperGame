using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevels : MonoBehaviour {

   /* public Button CurrentButton
    {
        get { return currentButton; }
        set { currentButton = value; }
    }
    [SerializeField]
    private Button currentButton;
    */
    [SerializeField]
    private int CurrentLevel;


    private void Start()
    {
       

        if (LevelControlers.instance._levels[CurrentLevel] == 1)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Button>().interactable = true;
           
        }


    }



}
