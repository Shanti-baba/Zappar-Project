using UnityEngine;

public class ObjectInsideCollider : MonoBehaviour
{
    public Collider parentCollider; // the collider that the objects should be inside

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent == parentCollider.transform)
        {
            other.gameObject.SetActive(true); // enable the game object if it's inside the collider
        }
        else
        {
            other.gameObject.SetActive(false); // disable the game object if it's outside the collider
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.SetActive(false); // disable the game object when it exits the collider
    }
}