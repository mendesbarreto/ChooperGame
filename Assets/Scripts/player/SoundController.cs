using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SoundController : MonoBehaviour {

    [SerializeField]
    private AudioSource som;
    private const float acceleration = 0.01f;

    private PlayerController componentFront;
    private PlayerController componentBack;


    public GameObject MoveFront
    {
        get { return moveFront; }
        set { moveFront = value; }
    }
    [SerializeField]
    private GameObject moveFront;

    public GameObject MoveBack
    {
        get { return moveBack; }
        set { moveBack = value; }
    }
    [SerializeField]
    private GameObject moveBack;

    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        componentFront = moveFront.GetComponent<PlayerController>();
        componentBack = moveBack.GetComponent<PlayerController>();
    }

    private void Update ()
    {
        MotorSound();
        StopSong();
	}

    private void MotorSound()
    {
        if (Input.GetAxisRaw("Vertical") != 0 || componentFront.Input == 1 || componentBack.Input == 1 && som.pitch < 3)
        {
            som.pitch = som.pitch + acceleration;
        }
        else if (som.pitch > 1)
        {
            som.pitch = som.pitch - acceleration;
        }
    }


    private void StopSong()
    {
        if (Time.timeScale == 0.0f)
        {
            som.Stop();
        }
    }
}
