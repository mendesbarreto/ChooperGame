using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SoundController : MonoBehaviour {

    [SerializeField]
    private AudioSource som;
    private const float acceleration = 0.01f;


    private void Update ()
    {
        MotorSound();
        StopSong();
	}

    private void MotorSound()
    {
        if (Input.GetAxisRaw("Vertical") != 0 && som.pitch < 3)
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
