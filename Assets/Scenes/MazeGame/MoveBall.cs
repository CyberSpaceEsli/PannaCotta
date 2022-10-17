using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{

 public float forceFactor = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 forceVector = new Vector3(h, 0, v);
        forceVector.Normalize();

        this.GetComponent<Rigidbody>().AddForce(forceFactor * forceVector);
    }
}
