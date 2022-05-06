using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Score variables
    private int _playerScore;
    private int _computerScore;

    // Ball reference
    public Ball ball;

    // This is called when starts up
    private void Awake() 
    {
        ResetScore();
    }

    // Reset score function
    private void ResetScore()
    {
        _playerScore = 0;
        _computerScore = 0;
    }

    // Adding player score
    public void AddPlayerScore()
    {
        // Add score
        _playerScore++;
        Debug.Log(_playerScore);
        // Reset ball 
        this.ball.ResetPosition();
    }

    // Adding Computer score
    public void AddComputerScore()
    {
        // Add score
        _computerScore++;
        Debug.Log(_computerScore);
        // Reset ball 
        this.ball.ResetPosition();
    }

}
