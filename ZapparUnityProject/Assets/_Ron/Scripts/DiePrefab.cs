using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiePrefab : MonoBehaviour
{
    public GameObject[] particalPrefab;
    public float modelTimer;
    public bool isInteractable = false; // boolean for interactable object

    // Start is called before the first frame update
    void Start()
    {
        if (isInteractable) // if object is interactable, add trigger collider
        {
            Collider collider = gameObject.AddComponent(typeof(BoxCollider)) as Collider;
            collider.isTrigger = true;
        }

        Invoke("KillModell", modelTimer);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isInteractable && other.gameObject.CompareTag("Player")) // only trigger if object is interactable
        {
            // Destroy this object
            Destroy(gameObject);
            // Instantiate explosion effect at this object's position
            Instantiate(particalPrefab[0], transform.position, Quaternion.identity);
            //Invoke("KillParticle", 1.0f);
            Debug.Log("EXPLOSION!!!");
         

        }
    }

    public void KillModell()
    {

        Destroy(gameObject);
    }
}
