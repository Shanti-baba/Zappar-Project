using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiePrefab : MonoBehaviour
{
    public float modelTimer;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("KillModell", modelTimer);
    }

    public void KillModell()
    {

        Destroy(gameObject);
    }
}
