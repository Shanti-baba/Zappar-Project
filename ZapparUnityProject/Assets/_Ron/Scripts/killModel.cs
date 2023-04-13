using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killModel : MonoBehaviour
{
    public GameObject particalPrefab;
    public float modelTimer;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("KillModell", modelTimer);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Destroy this object
            Destroy(gameObject);
            // Instantiate explosion effect at this object's position
            Instantiate(particalPrefab, transform.position, Quaternion.identity);
            //Invoke("KillParticle", 1.0f);
            Debug.Log("EXPLOSION!!!");
            // Play explosion sound effect

        }
    }

    public void KillModell()
    {

        Destroy(gameObject);
    }
}
