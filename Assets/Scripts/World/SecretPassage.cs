using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SecretPassage : MonoBehaviour {

    [SerializeField]
    private string objectTag;
    [SerializeField]
    private ParticleSystem BrokeEffect;

    private const string explosionAct = "ExplosionAct";



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == objectTag)
        {
            StartCoroutine(explosionAct);
        }
    }
    
    IEnumerator ExplosionAct()
    {
        yield return new WaitForSeconds(0.3f);
        if (BrokeEffect != null)
        {
            SpecialEffect.Instance.Explosion(transform.position);
        }
        Destroy(gameObject);
    } 
}
