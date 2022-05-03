using UnityEngine;

public class Player_paddle : paddle
{
    // Direction variable for player input
    private Vector2 _direction;

    // Update is called once per frame
    private void Update()
    {
        // Check what key was pressed
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    // Fixed update is called at a fixed timestamp
    private void FixedUpdate() 
    {
        if(_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * _speed);
        }
    }
}
