using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5;
    private float turnSpeed = 40;
    private float horizontalInput;
    private float forwardInput;
    private float xRange = 200;
    private float zRange = 200;

    public GameObject cannonBall;
    public GameObject muzzle;
        
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Limit the area where the player can move.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // Shoot
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(cannonBall, muzzle.transform.position, muzzle.transform.rotation);
        }
    }
}
