using UnityEngine;

public class Computer_paddle : Paddle
{
    // Variable to reference to ball
    public Rigidbody2D ball;

    // Track position of ball
    private void FixedUpdate() 
    {
        // Check if ball is moving
        if(this.ball.velocity.x > 0.0f)
        {
            // Check if ball is above computer paddle
            if(this.ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this._speed);
            }
            else if(this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this._speed);
            }
        }
        // else
        // {
        //     // Go back to 0 point if ball is going to player paddle
        //     if(this.transform.position.y > 0.0f)
        //     {
        //         _rigidbody.AddForce(Vertor2.down * this._speed);
        //     }
        //     else if(this.transform.position.y < 0.0f)
        //     {
        //         _rigidbody.AddForce(Vertor2.up * this._speed);
        //     }
        // }
    }
}
