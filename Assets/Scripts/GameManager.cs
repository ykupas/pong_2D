using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Score variables
    private int _playerScore;
    private int _computerScore;

    // Ball reference
    public Ball ball;

    // Adding player score
    public void AddPlayerScore()
    {
        // Add score
        _playerScore++;
        // Reset ball 
        this.ball.ResetPosition();
    }

    // Adding Computer score
    public void AddComputerScore()
    {
        // Add score
        _computerScore++;
        // Reset ball 
        this.ball.ResetPosition();
    }

}
