using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 15f;
    protected new Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void ResetPosition()
    {
        rigidbody.velocity = Vector3.zero;
        rigidbody.position = new Vector3(rigidbody.position.x, 0f, 0f);
    }

}
