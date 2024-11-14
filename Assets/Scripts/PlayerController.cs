using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpForce;

    public bool isGrounded = true;

    bool jumpPressed = false;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressed = true;
        }
    }


    private void FixedUpdate() 
    {
        if (jumpPressed && isGrounded)
        {
            rb.AddForce(jumpForce * Vector2.up, ForceMode2D.Impulse);
            jumpPressed = false;
            isGrounded = false;
        }

    }


}
