using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpScale;
    public float health;
    public float rotateSpeed;

    public Transform topLeft;
    public Transform bottomRight;
    public LayerMask platforms;

    private Rigidbody2D rb;
    private bool isGrounded;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    }

    void FixedUpdate()
    {
        // Left and right movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(moveHorizontal * moveSpeed, 0), Space.World);

        // Jumping
        isGrounded = Physics2D.OverlapArea(topLeft.position, bottomRight.position, platforms);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpScale));
        }
    }
}
