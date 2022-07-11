using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jumpPower = 200f;
    private bool isJumping = false;

    private Rigidbody2D rb;
    private float speed = 0.02f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("d"))
        {
            position.x += speed;
        }

        else if (Input.GetKey("a"))
        {
            position.x -= speed;
        }

        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector2.up * jumpPower;
            isJumping = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
