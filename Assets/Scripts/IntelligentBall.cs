using UnityEngine;

public class IntelligentBall : MonoBehaviour
{
    public float speed = 10f;
    public new Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        rigidbody.velocity = new Vector3(0f,0f,0f);
        rigidbody.position = new Vector3(0f,0f,0f);
    }

    public void AddStartingForce()
    {
        // Flip a coin to determine if the ball starts left or right
        float x = Random.value < 0.5f ? -1f : 1f;

        // Flip a coin to determine if the ball goes up or down. Set the range
        // between 0.5 -> 1.0 to ensure it does not move completely horizontal.
        float z = Random.value < 0.5f ? Random.Range(-1f, -0.5f)
                                      : Random.Range(0.5f, 1f);

        Vector3 direction = new Vector3(x, 0f, z);
        rigidbody.AddForce(direction * speed, ForceMode.Impulse);
    }

    public void AddForce(Vector3 force)
    {
        rigidbody.AddForce(force, ForceMode.Impulse);
    }

}
