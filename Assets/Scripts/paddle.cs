using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Protected variable can be accessed from child classes
    protected Rigidbody2D _rigidbody;
    
    // Paddle speed variable
    protected float _speed = 30.0f;

    // Awake is called one time, for initialization
    private void Awake() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Reset position of paddle
    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector3.zero;
    }
}
