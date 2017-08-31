using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField]
    private float maxX;
    [SerializeField]
    private float minX;
    [SerializeField]
    private float maxY;
    [SerializeField]
    private float minY;

    public Transform player;

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, minX, maxX),
                                         Mathf.Clamp(player.position.y, minY, maxY),
                                         transform.position.z);
    }
}
