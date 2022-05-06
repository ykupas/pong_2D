using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Score variables
    private int _playerScore;
    private int _computerScore;
    // Ball reference variable
    public Ball ball;
    // Text reference variables
    public Text playerScoreText;
    public Text computerScoreText;

    // This is called when starts up
    private void Awake() 
    {
        // ResetScore();
    }

    // Reset score function
    private void ResetScore()
    {
        // Reseting values
        _playerScore = 0;
        _computerScore = 0;
        // Reseting texts
        this.playerScoreText.text = _playerScore.ToString();
        this.computerScoreText.text = _computerScore.ToString();
    }

    // Adding player score
    public void AddPlayerScore()
    {
        // Add score
        _playerScore++;
        // Updating text
        this.playerScoreText.text = _playerScore.ToString();
        // Reset ball 
        this.ball.ResetPosition();
    }

    // Adding Computer score
    public void AddComputerScore()
    {
        // Add score
        _computerScore++;
        // Updating text
        this.computerScoreText.text = _computerScore.ToString();
        // Reset ball 
        this.ball.ResetPosition();
    }

}
