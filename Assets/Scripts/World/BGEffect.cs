using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BGEffect : MonoBehaviour {


    [SerializeField]
    private GameObject Camera;
    [SerializeField]
    private float speedCenario;

    private const float moveInX = -21.8f;
    private const float moveInY = -0.4846725f;

    private void Update()
    {
        MoveBG();
    }

    private void MoveBG()
    {
        transform.position = new Vector2(moveInX + (-Camera.transform.position.x / speedCenario), moveInY + ((-Camera.transform.position.y / speedCenario)));
    }





}
