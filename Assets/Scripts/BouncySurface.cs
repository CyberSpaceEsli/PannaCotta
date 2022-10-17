using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter(Collision collision)
    {
        IntelligentBall ball = collision.gameObject.GetComponent<IntelligentBall>();

        if (ball != null)
        {
            Vector3 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
