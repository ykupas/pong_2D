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
}
