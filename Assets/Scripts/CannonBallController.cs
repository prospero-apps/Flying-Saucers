using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallController : MonoBehaviour
{
    private float speed = 10;
    private float maxDistance = 50;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Vector3.Distance(initialPosition, transform.position) > maxDistance )
        {
            Destroy(gameObject);
        }
    }
}
