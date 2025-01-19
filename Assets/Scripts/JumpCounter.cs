using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpCounter : MonoBehaviour
{
    public Text jumpText;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private int jumpCount = 0;
    private bool isGrounded;

    void start()
    {
        UpdateJumpText();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            jumpCount++;
            UpdateJumpText();
        }
    }

    void UpdateJumpText()
    {
        jumpText.text = "Jumps: " + jumpCount.ToString();
    }
}
