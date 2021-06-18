using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public Joystick joystick;
    private float rotateVertical;
    private float rotateHorizontal;

    private float minClamp = -40.0f;
    private float maxClamp = 40f;

    private const float rotationalSpeed = 70f;

    void Update()
    {
        rotateVertical = Mathf.Clamp(joystick.Vertical * rotationalSpeed, minClamp, maxClamp);
        rotateHorizontal = Mathf.Clamp(joystick.Horizontal * -rotationalSpeed, minClamp, maxClamp);

        if (rotateVertical == 0 && rotateHorizontal == 0)
        {
            rotateVertical = Mathf.Lerp(transform.rotation.x * rotationalSpeed, 0, Time.deltaTime);
            rotateHorizontal = Mathf.Lerp(transform.rotation.z * rotationalSpeed, 0, Time.deltaTime);
        }

        transform.eulerAngles = new Vector3(rotateVertical, 0, rotateHorizontal);
    }
}
