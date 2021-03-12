using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    public BoxCollider2D colider;
    public Rigidbody2D rb;
    private float width;
    private float scrollSpeed = -2f;
    void Start()
    {
        colider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        width = colider.size.x;
        colider.enabled = false;
        rb.velocity = new Vector2(scrollSpeed, 0);
    }
    void Update()
    {
        if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
