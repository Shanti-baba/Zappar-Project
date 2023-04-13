using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawning : MonoBehaviour
{
    public SpawnObjects [] spawnerScript;
    public GameObject container;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(container.activeInHierarchy == false)
        {
            spawnerScript[0].start = false;
            spawnerScript[1].start = false;
            spawnerScript[2].start = false;
            spawnerScript[3].start = false;
            spawnerScript[4].start = false;
            spawnerScript[5].start = false;

        }
    }
}
