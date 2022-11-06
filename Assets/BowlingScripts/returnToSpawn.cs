using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnToSpawn : MonoBehaviour
{
    Rigidbody ball;
    Vector3 ballPosition;
    Vector3 originalVelocity;
    Vector3 originalRotation;

    void Start()
    {
        ballPosition = transform.position;
        ball = GetComponent<Rigidbody>();
        originalVelocity = transform.TransformVector(originalVelocity);
        originalRotation = transform.TransformVector(originalRotation);
    }

    void Update()
    {
      if (Input.GetButtonDown("Jump"))
        {
            ball.velocity = Vector3.zero;
            ball.angularVelocity = Vector3.zero;
            transform.position = ballPosition;
        }
      
     // if (Input.GetButtonDown("Fire1"))
       // {
         //   ball.velocity = originalVelocity;
           // ball.angularVelocity = originalRotation;
        //}
    }
}
