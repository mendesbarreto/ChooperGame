using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BGEffect : MonoBehaviour {


    [SerializeField]
    private GameObject Camera;
    [SerializeField]
    private float speedCenario;


    private void Update()
    {
        MoveBG();
    }

    private void MoveBG()
    {
        transform.position = new Vector2(-21.8f + (-Camera.transform.position.x / speedCenario), -0.4846725f + ((-Camera.transform.position.y / speedCenario)));
    }





}
