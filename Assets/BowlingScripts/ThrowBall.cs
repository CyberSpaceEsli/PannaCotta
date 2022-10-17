using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    public GameObject ball;
    public float movementSpeed = 5.0f;
    public float shootStrength = 20f;
    private int shootCount = 0;
    
    
    void Start ()
    {
        
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 horizontalMovement = new Vector3(1, 0, 0)* movementSpeed * Time.deltaTime;
        Vector3 verticalShoot = new Vector3(0, 0, 1) * shootStrength;



        if (Input.GetButton("Fire1"))

        {

            ball.GetComponent<Rigidbody>().AddForce(verticalShoot, ForceMode.Impulse);
            shootCount++;

        }

        if (Input.GetButton("Fire1") && shootCount.Equals(1))

        {

            ball.GetComponent<Rigidbody>().AddForce(verticalShoot, ForceMode.Impulse);
            shootCount++;

        }

        if (horizontalInput != 0)
        {
            ball.transform.position += horizontalMovement * horizontalInput;
        }

        
    }
}