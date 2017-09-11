using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CameraFollow : MonoBehaviour {

    [SerializeField]
    private float maxX;
    [SerializeField]
    private float minX;
    [SerializeField]
    private float maxY;
    [SerializeField]
    private float minY;
    [SerializeField]
    private Transform player;

    private void Update()
    {
        MoveCamera();  
    }

    private void MoveCamera()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, minX, maxX), Mathf.Clamp(player.position.y, minY, maxY), transform.position.z);
    }

}
