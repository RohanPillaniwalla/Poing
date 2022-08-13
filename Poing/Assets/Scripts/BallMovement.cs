using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 ballStartPosition;

    private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //calling the BallLauncher
        ballStartPosition = transform.position;
        BallLauncher();
    }

    //Launching the ball in random direction
    private void BallLauncher ()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;     //setting value of x between -1 and 1
        float y = Random.Range(0, 2) == 0 ? -1 : 1;     //setting value of x between -1 and 1

        //giving velocity to ball in certain direction
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    //Reset the position of ball
    // launch after position reset
    public void BallReset()
    {
        rb.velocity = Vector2.zero;
        transform.position = ballStartPosition;
        BallLauncher();
    }
}
