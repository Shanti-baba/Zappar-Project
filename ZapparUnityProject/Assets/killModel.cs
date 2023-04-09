using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("KillModel", 6.8f);
    }

    public void KillModel()
    {
        Destroy(gameObject);
    }
}
