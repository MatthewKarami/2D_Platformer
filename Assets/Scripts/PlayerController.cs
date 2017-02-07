using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpScale;
    public float health;
    public float rotateSpeed;

    private Rigidbody2D rb;
    private float distToGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        distToGround = rb.GetComponent<BoxCollider2D>().bounds.extents.y;
    }

    void Update()
    {
        // Left and right movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(moveHorizontal * moveSpeed, 0), Space.World);

        // Rotation
        float rotate = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(0, 0, rotate * rotateSpeed));

        // Jumping
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.AddForce(new Vector2(0, jumpScale));
        }
    }

    // Checks to see if Player_1 is touching ground (Broken)
    private bool isGrounded()
    {
        return Physics2D.Raycast(transform.position, -Vector3.up, distToGround + .1f);
    }

}
