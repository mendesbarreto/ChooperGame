using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialEffect : MonoBehaviour {

    public static SpecialEffect Instance;

    [SerializeField]
    private ParticleSystem brokeEffect;


    void Awake()
    {

        if (Instance != null)
        {
            Debug.LogError("Multiple instances of SpecialEffectsHelper!");
        }

        Instance = this;
    }


    public void Explosion(Vector2 position)
    {
        instantiate(brokeEffect, position);
    }

    private ParticleSystem instantiate(ParticleSystem prefab, Vector2 position)
    {
        ParticleSystem newParticleSystem = Instantiate(prefab, position, Quaternion.identity) as ParticleSystem;

        Destroy(newParticleSystem.gameObject, newParticleSystem.main.startLifetimeMultiplier);
        Debug.Log("aqui e o script do efeito especial");
        return newParticleSystem;
    }
}
