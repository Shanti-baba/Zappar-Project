using System.Collections;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] prefabs;
    public float minTime = 1f;
    public float maxTime = 3f;
    public float speed = 5f;
    public GameObject spawnerContainer;
    public bool start;
    private void Start()
    {
       // StartCoroutine(SpawnPrefab());
    }

    private IEnumerator SpawnPrefab()
    {
        while (true)
        {
            // Wait for a random time between minTime and maxTime
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));

            // Spawn a random prefab at the position of this object
            int randomIndex = Random.Range(0, prefabs.Length);
            GameObject newObject = Instantiate(prefabs[randomIndex], transform.position, transform.rotation);

            // Move the new object on the Z axis
            Rigidbody rb = newObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = -transform.forward * speed;
            }
        }
    }

    private void Update()
    {
        if (spawnerContainer.activeInHierarchy == true && !start)
        {  
            StartCoroutine(SpawnPrefab());
            Debug.Log("START IS TRUE NOW");
            start = true;
            //return;

        }
     
    }

  

}