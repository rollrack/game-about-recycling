using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movementSpeedMultiplier;
    public float jumpForce = 20f;
    float mw;
    float horizontalMove = 0f;
    public LayerMask groundLayers;
    public Transform feet;
    public Animator animator;
    void Update()
    {
        horizontalMove = mw = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        Vector2 movement = new Vector2(mw * movementSpeedMultiplier, rb.velocity.y);
        rb.velocity = movement;

        Vector3 characterScale = transform.localScale;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            characterScale.x = -0.06f;
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            characterScale.x = 0.06f;
        }

        transform.localScale = characterScale;
    }
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            Jump();
        }

        bool isGrounded()
        {
            Collider2D groundcheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);
            return groundcheck.gameObject != null;
        }

        void Jump()
        {
            Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
            rb.velocity = movement;
        }   
    }
}
