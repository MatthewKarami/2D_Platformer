using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseHealth : PowerUp {
    
    public int value;
    // Use this for initialization
    void Start () {
        timer = .5f;
        value = 10;
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isUsed && collision.gameObject.name == "Player_1")
        {
            player.health += value;
            isUsed = true;
        }
    }
    public override void Reset()
    {
        // no reset
    }
}
