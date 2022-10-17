using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody ball;

    private void FixedUpdate()
    {
        // Check if the ball is moving towards the paddle (positive x velocity)
        // or away from the paddle (negative x velocity)
        if (ball.velocity.x < 0f)
        {
            // Move the paddle in the direction of the ball to track it
            if (ball.position.z > rigidbody.position.z) {
                rigidbody.AddForce(Vector3.forward * speed);
            } else if (ball.position.z < rigidbody.position.z) {
                rigidbody.AddForce(Vector3.back * speed);
            }
        }
        else
        {
            // Move towards the center of the field and idle there until the
            // ball starts coming towards the paddle again
            if (rigidbody.position.z > 0f) {
                rigidbody.AddForce(Vector3.back * speed);
            } else if (rigidbody.position.z < 0f) {
                rigidbody.AddForce(Vector3.forward * speed);
            }
        }
    }

}
