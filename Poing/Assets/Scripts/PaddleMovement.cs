using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    private float speed = 5f;
    private float movement;

    public Rigidbody2D rb;
    public bool isPlayer1;
    public Vector3 paddleStartPosition;

    void Start()
    {
        paddleStartPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //checking for player1
        if(isPlayer1)
        {
            //get vertical from input
            movement = Input.GetAxisRaw("Vertical");
        }else
        {
            //get vertical2 from input
            movement = Input.GetAxisRaw("Vertical2");
        }

        //modify the velocity of the gameobject on y axis only
        rb.velocity = new Vector2(rb.velocity.x, speed * movement);
    }

    //Reset the position of paddles
    public void PaddleReset()
    {
        rb.velocity = Vector2.zero;
        transform.position = paddleStartPosition;
    }
}
