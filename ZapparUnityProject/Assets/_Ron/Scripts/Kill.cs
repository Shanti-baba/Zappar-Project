using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public float destroyTime;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Bye", destroyTime);
    }

    void Bye()
    {
        Destroy(gameObject);
    }
}
