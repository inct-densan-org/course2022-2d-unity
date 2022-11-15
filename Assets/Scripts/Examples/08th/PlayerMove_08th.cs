using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_08th : MonoBehaviour
{
    public float jumpPower = 200f;
    private bool isJumping = false;
    private bool isRun = false;

    private Rigidbody2D rb;
    private Animator animator;
    private float speed = 0.02f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("d"))
        {
            position.x += speed;
            isRun = true;
        } else if (Input.GetKey("a"))
        {
            position.x -= speed;
            isRun = true;
        } else {
            isRun = false;
        }

        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector2.up * jumpPower;
            isJumping = true;
        }

        animator.SetBool("isRun", isRun);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
