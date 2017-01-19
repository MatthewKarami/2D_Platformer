using UnityEngine;
using System.Collections;

public class Player_1_Controll : MonoBehaviour {

    public double moveSpeed;
    public float jumpScale;

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
        Vector3 movement = new Vector3(moveHorizontal, 0);
        this.transform.Translate(movement);

        // Jumping
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.AddForce(new Vector3(0, jumpScale));
        }
    }

    // Checks to see if Player_1 is touching ground
    private bool isGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }

}
