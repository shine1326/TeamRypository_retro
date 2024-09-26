using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField, Header("ˆÚ“®‘¬“x")]
    private float _speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        Vector2 Position = transform.position;

        if (Input.GetKey("left")) {
            moveX -= _speed;
        }

        if (Input.GetKey("right")) {
            moveX += _speed;
        }

        if (Input.GetKey("up")) {
            moveY += _speed;
        }

        if (Input.GetKey("down")) {
            moveY -= _speed;
        }

        if (moveX != 0f && moveY != 0f) {
            moveX /= 1.4f;
            moveY /= 1.4f;
        }

        Position.x += moveX;
        Position.y += moveY;

        transform.position = Position;
    }
}
