using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretPassage : MonoBehaviour {

    [SerializeField]
    private string objectTag;
    [SerializeField]
    private ParticleSystem BrokeEffect;

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == objectTag)
        {
            StartCoroutine("ExplosionAct");
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
