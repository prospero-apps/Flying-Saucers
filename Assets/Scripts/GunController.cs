using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    //public float xTurnSpeed = 60;
    public float yTurnSpeed = 60;
    //public float xMouseInput;
    public float yMouseInput;
    private float minAngle = 45;
    private float maxAngle = 90;

    void Update()
    {
        //xMouseInput = Input.GetAxis("Mouse X");
        yMouseInput = Input.GetAxis("Mouse Y");

        Vector3 currentRotation = transform.localEulerAngles;
        float gunRotation = yMouseInput * yTurnSpeed * Time.deltaTime;
        currentRotation.x -= gunRotation;
        currentRotation.x = Mathf.Clamp(currentRotation.x, minAngle, maxAngle);
        transform.localEulerAngles = currentRotation;

        
        //transform.Rotate(transform.up, Mathf.Clamp(xTurnSpeed * (-xMouseInput) * Time.deltaTime, -maxAngle, maxAngle));
        //transform.Rotate(transform.right, Mathf.Clamp(yTurnSpeed * (-yMouseInput) * Time.deltaTime, -maxAngle, maxAngle));
    }
}
