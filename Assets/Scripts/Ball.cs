using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    [SerializeField] float xLaunch = 2f;
    [SerializeField] float yLaunch = 15f;



    Vector2 paddleBallGap;
    bool gameStarted = false;



    // Start is called before the first frame update
    void Start()
    {
        paddleBallGap = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            LockBallOnPaddle();
            LaunchBall();

        }
    }

    private void LockBallOnPaddle()
    {
        Vector2 paddlePosition = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePosition + paddleBallGap;
    }

    private void LaunchBall()
    {
        if (Input.GetMouseButtonDown(0))
            {
            gameStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xLaunch, yLaunch);
            }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameStarted)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
