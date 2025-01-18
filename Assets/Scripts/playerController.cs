using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
       
        float move = Input.GetAxis("Horizontal");
        rb.velocity= new Vector2(move * speed, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
