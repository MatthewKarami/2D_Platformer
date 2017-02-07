using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : PowerUp {

    public float value;
    void Start()
    {
        timer = 3f;
        value = 2;
    }
	
	// Update is called once per frame
	void Update () {
        base.Update();
	}

    void OnCollisionEnter2D(Collision2D collision)
    { 
        if (!isUsed && collision.gameObject.name == "Player_1")
        {
            Debug.Log("Speed madafka");
            player.moveSpeed *= value;
            isUsed = true;
        }
    }

    public override void Reset()
    {
        player.moveSpeed /= value;
    }
}
