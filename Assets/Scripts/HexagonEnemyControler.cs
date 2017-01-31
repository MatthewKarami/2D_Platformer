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
        if (collision.gameObject.tag == "TurnTrigger")
        {
            direction = direction * -1;
        }
    }
}
