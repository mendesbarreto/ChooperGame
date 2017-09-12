using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour {
    [SerializeField]
    private AudioSource GameTheme;
    [SerializeField]
    private AudioSource PauseTheme;

    private void Start()
    {
        GameTheme.Play();
    }

    private void Update()
    {
        if (Time.timeScale == 0.0f)
        {
            GameTheme.Stop();
            if (!PauseTheme.isPlaying)
            {
                PauseTheme.Play();
            }
        }
        else
        {
            PauseTheme.Stop();
            if (!GameTheme.isPlaying)
            {
                GameTheme.Play();
            }
        }



    }   

}
