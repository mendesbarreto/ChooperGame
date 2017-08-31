using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretPassage : MonoBehaviour {

    [SerializeField]
    private string objectTag;
    [SerializeField]
    private ParticleSystem BrokeEffect;

    //COLIDIR COM ESPINHOS
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == objectTag)
        {
            StartCoroutine("Respawn");
        }

    }
    

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(0.3f);
        //criando efeito de particula
        SpecialEffect.Instance.Explosion(transform.position);
        Destroy(gameObject);
       
    }


   
}
