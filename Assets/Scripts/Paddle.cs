using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{   
    float minX = 1.25f;
    float maxX = 14.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosit = Input.mousePosition.x / (Screen.width / 16);
        Vector2 positionOfPaddle = new Vector2(transform.position.x, transform.position.y);
        positionOfPaddle.x = Mathf.Clamp(mousePosit, minX, maxX);
        transform.position = positionOfPaddle;

    }
}
