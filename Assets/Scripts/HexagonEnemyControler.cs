using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonEnemyControler : MonoBehaviour {

    public float moveSpeed;

    private int direction;

	void Start () {
        direction = -1;
	}
	
	void Update () {
        transform.Translate(new Vector2(direction * moveSpeed, 0), Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Reverses hexagon's direction of movement when hexagon collides with TurnTrigger 
        if (collision.gameObject.tag == "TurnTrigger")
        {
            direction = direction * -1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Kills the enemy when Player_1 hits it from above
        Vector2 v = (Vector3)collision.contacts[0].point - transform.position;

        if (collision.gameObject.name == "Player_1" && Mathf.Abs(Vector2.Angle(v, Vector2.up)) < 45.0)
        {
            Destroy(this.gameObject);
        }
    }
}
