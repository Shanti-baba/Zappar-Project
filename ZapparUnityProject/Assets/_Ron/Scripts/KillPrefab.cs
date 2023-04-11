using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KillPrefab : MonoBehaviour
{
    public GameObject explosionPrefab;
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Destroy this object
            Destroy(gameObject);
            // Instantiate explosion effect at this object's position
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
           // Invoke("KillParticle", 1.0f);

            
            
        }
    }

 

}
