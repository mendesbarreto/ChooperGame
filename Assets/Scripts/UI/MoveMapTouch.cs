﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMapTouch : MonoBehaviour {

    public float speed;
    private Vector3 limiteRight = new Vector3(-1,0,0);
    private Vector3 limiteLeft = new Vector3(-19,0,0);

    // Use this for initialization
    void Start()
    {
        speed = 0.01f;
    }

   
    void Update()
    {

       

        if (transform.position.x > 0f)
        {
            transform.position = Vector3.Lerp(transform.position, limiteRight, Time.deltaTime);
      
        } else if (transform.position.x < -20)
        {
            transform.position = Vector3.Lerp(transform.position, limiteLeft, Time.deltaTime);

        } else
        {
            if (Input.touchCount == 1)
            {
                transform.Translate(Input.touches[0].deltaPosition.x * speed, 0, 0);
            }
        }


    }
}
