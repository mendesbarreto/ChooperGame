﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class MoveMapTouch : MonoBehaviour {

    [SerializeField]
    private float speed;
    private Vector3 limiteRight = new Vector3(-1,0,0);
    private Vector3 limiteLeft = new Vector3(-19,0,0);

   
    private void Start()
    {
        LoadResources();  
    }

    private void LoadResources()
    {
        speed = 0.01f;
    }


    private void Update()
    {
        MoveMap();
    }


    private void MoveMap()
    {
        if (transform.position.x > 0f)
        {
            transform.position = Vector3.Lerp(transform.position, limiteRight, Time.deltaTime);

        }
        else if (transform.position.x < -20)
        {
            transform.position = Vector3.Lerp(transform.position, limiteLeft, Time.deltaTime);

        }
        else
        {
            if (Input.touchCount == 1)
            {
                transform.Translate(Input.touches[0].deltaPosition.x * speed, 0, 0);
            }
        }
    }


}
