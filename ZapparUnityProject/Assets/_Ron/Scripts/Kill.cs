using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Bye", 1.0f);
    }

    void Bye()
    {
        Destroy(gameObject);
    }
}
