using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoystickRotation : MonoBehaviour
{
    public Joystick joystick;
    public float rotateHorizontal;
    public float rotationSpeed = 10f;

    private void FixedUpdate()
    {
        rotateHorizontal = joystick.Horizontal * -1f;
        Quaternion rotation = Quaternion.Euler(0, rotateHorizontal * rotationSpeed, 0);
        transform.localRotation *= rotation;
    }

   
}