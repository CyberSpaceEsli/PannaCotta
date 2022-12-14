using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector3 direction;

    private void Update()
    {
        // if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.RightArrow)) {
        //     direction = Vector3.forward;
        // } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.LeftArrow)) {
        //     direction = Vector3.back;
        // } else {
        //     direction = Vector3.zero;
        // }
        float horizontalInput = Input.GetAxis("Horizontal");
        

        Vector3 movementDirection = new Vector3(0, 0, horizontalInput*this.speed);

        transform.Translate(movementDirection * Time.deltaTime );
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0) {
            rigidbody.AddForce(direction * this.speed);
        }
    }

}
