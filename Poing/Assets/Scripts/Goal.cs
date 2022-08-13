using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    //check ball collide with either playerGoal
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball")) 
        {
            //check for ball collide with player1goal 
            //update player2score if true
            if (isPlayer1Goal)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
            //else ball collide with player2goal
            // update player1score
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
        }
    }
}
