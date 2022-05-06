using UnityEngine;

public class Bouncy_suface : MonoBehaviour
{
    // Bounce Strength variable
    public float _bounceStrength;

    // This is called every time a collision 2D is detected
    private void OnCollisionEnter2D(Collision2D other) 
    {
        // Try to find Ball.cs component in other
        Ball ball = other.gameObject.GetComponent<Ball>();
        // Check if it was found
        if(ball != null)
        {
            // Get normal Vector2 from Ball first contact
            Vector2 normal = other.GetContact(0).normal;
            // Add normal opposite force to ball
            ball.AddForce(-normal * this._bounceStrength);
        }

    }
}
