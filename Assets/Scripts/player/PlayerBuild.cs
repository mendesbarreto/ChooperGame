using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuild : MonoBehaviour {

    [SerializeField]
    private int PlayerListRange = 3;

    [SerializeField]
    private GameObject[] playerList = new GameObject[3];

    private void Awake()
    {
        ActiveCurrentPlayer();
    }

    private void ActiveCurrentPlayer()
    {
        for (int i = 0; i < PlayerListRange; i++)
        {
            if (MainGame.instance.CurrentObject != i)
            {
                playerList[i].SetActive(false);
            }
        }
    }

}
