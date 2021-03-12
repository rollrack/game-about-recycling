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
    void Update()
    {
        horizontalMove = mw = Input.GetAxisRaw("Horizontal");
        {
            Vector2 movement = new Vector2(mw * movementSpeedMultiplier, rb.velocity.y);
            rb.velocity = movement;
        }

        Vector3 characterScale = transform.localScale;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            characterScale.x = -2;
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            characterScale.x = 2;
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
            if(groundcheck.gameObject != null)
            {
                return true;
            }
            return false;
        }

        void Jump()
        {
            Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
            rb.velocity = movement;
        }
    }
}
