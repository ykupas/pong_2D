using UnityEngine;

public class Ball : MonoBehaviour
{
    // Private variable for Rigidbody2D
    private Rigidbody2D _rigidbody;
    // Speed variable
    private float _speed = 200.0f;

    // Awake is called before the first frame update
    private void Awake()
    {
        // Point Ball rigidbody to variable
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called just after Awake
    private void Start() 
    {
        ResetPosition();    
        AddStartingForce();
    }

    // Reset ball position 
    public void ResetPosition()
    {
        // Reseting position and velocity
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
    }

    // Adding a starting force to ball
    public void AddStartingForce()
    {
        // Variables for X and Y axis force
        float x;
        float y;

        // Create a random starting X direction
        if(Random.value < 0.5f)
            x = -1f;
        else
            x = +1f;

        // Create a random starting Y direction
        if(Random.value < 0.5f)
            // If maximum was 0f, ball can go totally horizontal
            y = Random.Range(-1.0f, -0.5f);
        else
            // If minimum was 0f, ball can go totally horizontal
            y = Random.Range(0.5f, 1.0f);

        // Add starting force to Ball's Rigidbody2D
        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * _speed);
    }

    // Function to add force to rigidbody
    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }


}
