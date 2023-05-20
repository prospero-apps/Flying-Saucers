using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public float yTurnSpeed = 60;
    public float yMouseInput;
    private readonly float minAngle = 60;
    private readonly float maxAngle = 90;

    void Update()
    {
        yMouseInput = Input.GetAxis("Mouse Y");

        Vector3 currentRotation = transform.localEulerAngles;
        float gunRotation = yMouseInput * yTurnSpeed * Time.deltaTime;
        currentRotation.x -= gunRotation;
        currentRotation.x = Mathf.Clamp(currentRotation.x, minAngle, maxAngle);
        transform.localEulerAngles = currentRotation;
    }
}
