using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        

        Vector3 movementDirection = new Vector3(horizontalInput, 0, 0);

        transform.Translate(movementDirection * Time.deltaTime );
    }
}
