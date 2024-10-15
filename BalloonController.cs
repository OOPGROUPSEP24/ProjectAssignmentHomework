using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed at which the balloon moves
    private bool movingRight = true; // Determines the initial direction of movement

    void Update()
    {
       
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

        
        if (transform.position.y > Camera.main.orthographicSize + 1f)
        {
            Destroy(gameObject);
        }
    }
}
