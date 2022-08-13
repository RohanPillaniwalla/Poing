using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{

    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;

    //updating player1 score 
    //writing it on the screen
    //reset the position of paddles and ball 
    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    //updating player2 score 
    //writing it on the screen
    //reset the position of paddles and ball
    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    //method to reset the position of paddles and ball
    public void ResetPosition()
    {
        ball.GetComponent<BallMovement>().BallReset();
        player1Paddle.GetComponent<PaddleMovement>().PaddleReset();
        player2Paddle.GetComponent<PaddleMovement>().PaddleReset();
    }
}
