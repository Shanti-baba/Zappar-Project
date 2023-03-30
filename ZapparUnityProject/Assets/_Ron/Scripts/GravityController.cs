using UnityEngine;

public class GravityController : MonoBehaviour
{
    public float gravity = -9.8f; // gravitational force, adjust as needed
    public float groundDistance = 0.1f; // distance from the game object's center to the ground
    public LayerMask groundLayer; // layer(s) that represent the ground
    private Vector3 velocity; // the velocity of the game object

    void FixedUpdate()
    {
        bool isGrounded = Physics.Raycast(transform.position, -Vector3.up, groundDistance, groundLayer); // detect if the game object is grounded using raycasting

        if (isGrounded)
        {
            velocity.y = 0f; // if the game object is grounded, reset its vertical velocity
        }
        else
        {
            velocity.y += gravity * Time.fixedDeltaTime; // if the game object is not grounded, apply the gravitational force
        }

        transform.position += velocity * Time.fixedDeltaTime; // move the game object based on the new velocity
    }
}
