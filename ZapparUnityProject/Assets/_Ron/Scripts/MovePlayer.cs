using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f;
    public float jumpHeight = 10f;
    public float invokeJumpTime = 0.5f;

    private bool isMovingLeft = false;
    private bool isMovingRight = false;
    private bool isJumping = false;

    private EventTrigger leftButtonTrigger;
    private EventTrigger rightButtonTrigger;
    private EventTrigger jumpButtonTrigger;

   

    private void Start()
    {
        // Get the UI button triggers
        leftButtonTrigger = GameObject.Find("LeftButton").GetComponent<EventTrigger>();
        rightButtonTrigger = GameObject.Find("RightButton").GetComponent<EventTrigger>();
      //  jumpButtonTrigger = GameObject.Find("JumpButton").GetComponent<EventTrigger>();

        // Set up the pointer down/up events for the left button
        var pointerDownLeft = new EventTrigger.Entry { eventID = EventTriggerType.PointerDown };
        pointerDownLeft.callback.AddListener((eventData) => StartMovingLeft());

        var pointerUpLeft = new EventTrigger.Entry { eventID = EventTriggerType.PointerUp };
        pointerUpLeft.callback.AddListener((eventData) => StopMovingLeft());

        leftButtonTrigger.triggers.Add(pointerDownLeft);
        leftButtonTrigger.triggers.Add(pointerUpLeft);

        // Set up the pointer down/up events for the right button
        var pointerDownRight = new EventTrigger.Entry { eventID = EventTriggerType.PointerDown };
        pointerDownRight.callback.AddListener((eventData) => StartMovingRight());

        var pointerUpRight = new EventTrigger.Entry { eventID = EventTriggerType.PointerUp };
        pointerUpRight.callback.AddListener((eventData) => StopMovingRight());

        rightButtonTrigger.triggers.Add(pointerDownRight);
        rightButtonTrigger.triggers.Add(pointerUpRight);

        // Set up the pointer down event for the jump button
        var pointerDownJump = new EventTrigger.Entry { eventID = EventTriggerType.PointerDown };
        pointerDownJump.callback.AddListener((eventData) => Jump());

       // jumpButtonTrigger.triggers.Add(pointerDownJump);
    }

    private void FixedUpdate()
    {
        // Move the player left or right
        if (isMovingLeft)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.position = new Vector3(Mathf.Clamp(transform.localPosition.x, -0.38f, 0.38f), transform.position.y, transform.position.z);
        }
        else if (isMovingRight)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            transform.position = new Vector3(Mathf.Clamp(transform.localPosition.x, -0.38f, 0.38f), transform.position.y, transform.position.z);
        }

     /*   // Jump the player
        if (isJumping)
        {
            transform.Translate(0, jumpHeight * Time.deltaTime, 0);
            isJumping = false;
            jumpButtonTrigger.enabled = false;
            rightButtonTrigger.enabled = false;
            leftButtonTrigger.enabled = false;
            Invoke("EnableJumpButton", invokeJumpTime);
            Invoke("EnableLeftButton", invokeJumpTime);
            Invoke("EnableRightButton", invokeJumpTime);
        }*/
    }

    public void StartMovingLeft()
    {
        isMovingLeft = true;
    }

    public void StopMovingLeft()
    {
        isMovingLeft = false;
    }

    public void StartMovingRight()
    {
        isMovingRight = true;
    }

    public void StopMovingRight()
    {
        isMovingRight = false;
    }

    public void Jump()
    {
        if (!isJumping)
        {
            isJumping = true;
        }
    }

    private void EnableJumpButton()
    {
        jumpButtonTrigger.enabled = true;
    }
    private void EnableLeftButton()
    {
        leftButtonTrigger.enabled = true;
    }
    private void EnableRightButton()
    {
        rightButtonTrigger.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {

            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}

